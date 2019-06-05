using ISUF.Base.Enum;
using ISUF.Base.Settings;
using ISUF.Base.Template;
using ISUF.Interface;
using ISUF.ItemStorage.Storage;
using ISUF.Security;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Storage;

namespace ISUF.Storage.Manager
{
    /// <summary>
    /// Storage manager class
    /// </summary>
    /// <typeparam name="T">Type of item</typeparam>
    abstract public class StorageManager<T> : IStorageManager<T> where T : BaseItem
    {
        PathType pathType { get; set; }
        string path { get; set; } = string.Empty;
        string fileName { get; set; } = string.Empty;

        protected ObservableCollection<T> ItemsSource { get; set; } = null;
        protected ObservableCollection<T> ItemsSourceAll { get; set; } = new ObservableCollection<T>();

        /// <summary>
        /// Set file name, that has serializaed data of type T
        /// </summary>
        /// <param name="fileName">Name of file, that has serialized data</param>
        public StorageManager(string fileName, string path = "")
        {
            if (path == "")
                pathType = PathType.Local;

            this.fileName = fileName;
        }

        /// <summary>
        /// Read data from file
        /// </summary>
        /// <param name="Attempts">Number of attempts</param>
        /// <returns>Collection of items of type T</returns>
        protected async Task<ObservableCollection<T>> ReadDataAsync(int Attempts = 0)
        {
            object ReadedObjects = null;

            try
            {
                XmlSerializer Serializ = new XmlSerializer(typeof(ItemStorage<T>));
                Stream XmlStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(fileName);

                using (XmlStream)
                {
                    ReadedObjects = (ItemStorage<T>)Serializ.Deserialize(XmlStream);
                }

                XmlStream.Dispose();

                if (ReadedObjects != null)
                {
                    ItemsSourceAll = ((ItemStorage<T>)ReadedObjects).Items;
                    ItemsSource = ((ItemStorage<T>)ReadedObjects).Items;

                    return new ObservableCollection<T>(((ItemStorage<T>)ReadedObjects).Items.Where(x => GetValidItems(x)));
                }
                else
                    return new ObservableCollection<T>();
            }

            // When is file unavailable - 10 attempts is enough
            catch (Exception s) when ((s.Message.Contains("denied")) && (Attempts < 10))
            {
                return await ReadDataAsync(Attempts + 1);
            }

            catch
            {
                return new ObservableCollection<T>();
            }
        }

        /// <summary>
        /// Get true/false statement for filtering items based on security
        /// </summary>
        /// <param name="x">Type of item</param>
        /// <returns>Result of logic. expression</returns>
        protected virtual bool GetValidItems(T x)
        {
            bool userLogged = CustomSettings.IsUserLogged;

            return x.Secured == userLogged || (x.Secured != userLogged && userLogged == true);
        }

        /// <summary>
        /// Check, if item exist in collection
        /// </summary>
        /// <param name="x">Check item</param>
        /// <returns>True, if not exist</returns>
        protected virtual bool GetDiff(T x)
        {
            return !ItemsSource.Contains(x);
        }

        /// <summary>
        /// Save data to file
        /// </summary>
        /// <param name="Attempts">Number of attempts</param>
        /// <returns>True, if save was succesful</returns>
        protected async Task<bool> SaveDataAsync(int Attempts = 0)
        {
            try
            {
                foreach (var item in ItemsSource.Where(x => x.Secured && !x.Encrypted))
                {
                    item.Name = Crypting.Encrypt(item.Name);
                    item.Description = Crypting.Encrypt(item.Description);
                    item.Encrypted = true;
                }

                var typeOfItem = nameof(T);

                ItemStorage<T> itemStorage = new ItemStorage<T>()
                {
                    Items = GetFinalCollection(),
                    TypeOfItem = typeOfItem
                };

                XmlSerializer Serializ = new XmlSerializer(typeof(ItemStorage<T>));

                using (Stream XmlStream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(fileName, CreationCollisionOption.ReplaceExisting))
                {
                    Serializ.Serialize(XmlStream, /*DeliveredData*/ itemStorage);
                }

                foreach (var item in ItemsSource.Where(x => x.Secured && x.Encrypted))
                {
                    item.Name = Crypting.Decrypt(item.Name);
                    item.Description = Crypting.Decrypt(item.Description);
                    item.Encrypted = false;
                }

                return true;
            }

            // When file is unavailable
            catch (Exception e) when ((e.Message.Contains("denied") || e.Message.Contains("is in use")) && (Attempts < 10))
            {
                return await SaveDataAsync(Attempts + 1);
            }

            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Get type, that class using
        /// </summary>
        /// <returns>Type used in class for ObservableCollection</returns>
        public Type GetClassType()
        {
            return typeof(T);
        }

        /// <summary>
        /// Get source collection of all items of type T for serializing
        /// </summary>
        /// <returns>Collection of items of type T</returns>
        abstract protected ObservableCollection<T> GetFinalCollection();

        /// <summary>
        /// Set source collection of items of type T for serializing
        /// </summary>
        /// <returns>Collection of items of type T</returns>
        abstract public void SetSourceCollection(ObservableCollection<T> source);
    }
}