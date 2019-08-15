using ISUF.Base.Modules;
using ISUF.Base.Service;
using ISUF.Base.Template;
using ISUF.Storage.Enum;
using ISUF.Storage.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Storage;

namespace ISUF.Storage.DatabaseAccess
{
    public class XmlDbAccess : DatabaseAccess
    {
        public XmlDbAccess(string connectionString, bool useChache) : base(connectionString, useChache)
        {
        }

        public override bool CheckConnectionString(string connectionString)
        {
            try
            {
                var fullPath = Path.GetFullPath(connectionString + @"\test.xml");
                return true;
            }
            catch (Exception ex)
            {
                LogService.AddLogMessage(ex.Message);
                return false;
            }
        }

        public override async Task<bool> AddItemIntoDatabase<T>(T newItem)
        {
            var allItems = GetAllItems<T>();

            var addStorageChange = new StorageChange()
            {
                InMemoryChange = useInMemoryCache,
                ModuleType = typeof(T),
                ID = newItem.ID,
                ChangeSaved = !useInMemoryCache,
                TypeOfChange = DbTypeOfChange.Add
            };

            dbChanges.Add(addStorageChange);

            if (useInMemoryCache)
            {
                inMemoryCache[typeof(T)].Add(newItem);

                return true;
            }
            else
            {
                var tableName = registeredModules[typeof(T)];
                return await SaveFileAsync(allItems, tableName);
            }
        }

        public override void CreateDatabaseTable<T>(string tableName)
        {
            try
            {
                using (FileStream file = File.Create($@"{connectionsString}\{tableName}.xml"))
                {

                }
            }
            catch (Exception ex)
            {
                LogService.AddLogMessage(ex.Message);
            }
        }

        public override ObservableCollection<T> GetAllItems<T>()
        {
            if (useInMemoryCache)
                return (ObservableCollection<T>)inMemoryCache[typeof(T)].Cast<T>();
            else
            {
                var tableName = registeredModules[typeof(T)];
                return ReadFileAsync<T>(tableName).Result;
            }
        }

        /// <summary>
        /// Read data from file
        /// </summary>
        /// <param name="Attempts">Number of attempts</param>
        /// <returns>Collection of items of type T</returns>
        protected async Task<ObservableCollection<T>> ReadFileAsync<T>(string tableName, int Attempts = 0) where T : BaseItem
        {
            object readedObjects = null;

            try
            {
                XmlSerializer Serializ = new XmlSerializer(typeof(ItemStorage<T>));
                Stream XmlStream = File.OpenRead($@"{connectionsString}\{tableName}.xml");

                using (XmlStream)
                {
                    readedObjects = (ItemStorage<T>)Serializ.Deserialize(XmlStream);
                }

                if (readedObjects != null)
                {

                    return ((ItemStorage<T>)readedObjects).Items;
                }
                else
                    return new ObservableCollection<T>();
            }

            // When is file unavailable - 10 attempts is enough
            catch (Exception ex) when ((ex.Message.Contains("denied")) && (Attempts < 10))
            {
                LogService.AddLogMessage(ex.Message);
                return await ReadFileAsync<T>(tableName, Attempts + 1);
            }

            catch (Exception ex)
            {
                LogService.AddLogMessage(ex.Message);
                return new ObservableCollection<T>();
            }
        }

        /// <summary>
        /// Save data to file
        /// </summary>
        /// <param name="Attempts">Number of attempts</param>
        /// <returns>True, if save was succesful</returns>
        protected async Task<bool> SaveFileAsync<T>(ObservableCollection<T> itemsToSave, string tableName, int Attempts = 0) where T : BaseItem
        {
            try
            {
                var typeOfItem = nameof(T);

                ItemStorage<T> itemStorage = new ItemStorage<T>()
                {
                    Items = itemsToSave,
                    TypeOfItem = typeOfItem
                };

                XmlSerializer Serializ = new XmlSerializer(typeof(ItemStorage<T>));

                using (Stream XmlStream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync($@"{connectionsString}\{tableName}.xml", CreationCollisionOption.ReplaceExisting))
                {
                    Serializ.Serialize(XmlStream, itemStorage);
                }

                return true;
            }

            // When file is unavailable
            catch (Exception ex) when ((ex.Message.Contains("denied") || ex.Message.Contains("is in use")) && (Attempts < 10))
            {
                LogService.AddLogMessage(ex.Message);
                return await SaveFileAsync(itemsToSave, tableName, Attempts + 1);
            }

            catch (Exception ex)
            {
                LogService.AddLogMessage(ex.Message);
                return false;
            }
        }

        public override T GetItem<T>(int ID)
        {
            return GetAllItems<T>().FirstOrDefault(x => x.ID == ID);
        }

        public override bool IsItemInDatabase<T>(int ID)
        {
            return GetItem<T>(ID) != null;
        }

        public override void RemoveAllRows()
        {
            FileStream clearedFile = null;

            try
            {
                clearedFile = File.Create(connectionsString);
            }
            finally
            {
                clearedFile.Dispose();
            }
        }

        public override void RemoveDatabaseTable(string tableName)
        {
            if (File.Exists(connectionsString))
                File.Delete($@"{connectionsString}\{tableName}.xml");
        }

        public override async Task<bool> RemoveRow<T>(int ID)
        {
            if (useInMemoryCache)
            {
                var allItems = inMemoryCache[typeof(T)];
                var itemToRemove = allItems.FirstOrDefault(x => x.ID == ID);

                if (itemToRemove != null)
                {
                    allItems.Remove(itemToRemove);
                    return true;
                }
                else
                    return false;
            }
            else
            {
                var allItems = GetAllItems<T>();
                var itemToRemove = allItems.FirstOrDefault(x => x.ID == ID);

                if (itemToRemove != null)
                {
                    allItems.Remove(itemToRemove);
                    var tableName = registeredModules[typeof(T)];

                    return await SaveFileAsync(allItems, tableName);
                }
                else
                    return false;
            }
        }

        public override async Task SetSourceCollection<T>(ObservableCollection<T> source)
        {
            if (useInMemoryCache)
            {
                inMemoryCache[typeof(T)] = (ObservableCollection<BaseItem>)source.Cast<BaseItem>();
            }
            else
            {
                var tableName = registeredModules[typeof(T)];
                await SaveFileAsync(source, tableName);
            }
        }

        public override void UpdateDatabaseTable<T>(string tableName)
        {
            RemoveDatabaseTable(tableName);
            CreateDatabaseTable<T>(tableName);
        }

        public override async Task<bool> UpdateItem<T>(T updateItem)
        {
            if (useInMemoryCache)
            {
                var allItems = inMemoryCache[typeof(T)];
                var itemToUpdate = allItems.FirstOrDefault(x => x.ID == updateItem.ID);
                var itemToUpdateIndex = allItems.IndexOf(itemToUpdate);

                allItems[itemToUpdateIndex] = updateItem;
                return true;
            }
            else
            {
                var allItems = GetAllItems<T>();
                var itemToUpdate = allItems.FirstOrDefault(x => x.ID == updateItem.ID);
                var itemToUpdateIndex = allItems.IndexOf(itemToUpdate);
                var tableName = registeredModules[typeof(T)];

                allItems[itemToUpdateIndex] = updateItem;
                return await SaveFileAsync(allItems, tableName);
            }
        }

        //protected override ObservableCollection<T> GetFinalCollection<T>()
        //{
        //    throw new NotImplementedException();
        //}

        public override async Task WriteInMemoryCache<T>()
        {
            var itemsToSave = inMemoryCache[typeof(T)];
            var tableName = registeredModules[typeof(T)];

            await SaveFileAsync(itemsToSave, tableName);
        }

        public override async Task ClearChangesInMemoryCache<T>()
        {
            await ReloadInMemoryCache<T>(false);
        }

        public override async Task<ObservableCollection<T>> ReloadInMemoryCache<T>(bool writeChangesIntoFB)
        {
            var itemsToSave = inMemoryCache[typeof(T)];
            var tableName = registeredModules[typeof(T)];

            await SaveFileAsync(itemsToSave, tableName);

            return await ReadFileAsync<T>(tableName);
        }
    }
}
