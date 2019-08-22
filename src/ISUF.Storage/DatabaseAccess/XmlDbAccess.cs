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

        public XmlDbAccess(bool useChache) : base(ApplicationData.Current.LocalFolder.ToString(), useChache)
        {
        }

        public override bool CheckConnectionString(string connectionString)
        {
            try
            {
                Path.GetFullPath(connectionString + @"\test.xml");
                return true;
            }
            catch (Exception ex)
            {
                LogService.AddLogMessage(ex.Message);
                return false;
            }
        }

        public override void CreateDatabase()
        {
            foreach (KeyValuePair<Type, string> module in registeredModules)
            {
                CreateDatabaseTable(module.Key);
            }
        }

        public override void UpdateDatabase()
        {
            foreach (KeyValuePair<Type, string> module in registeredModules)
            {
                UpdateDatabaseTable(module.Key);
            }
        }

        public override void RemoveDatabase()
        {
            foreach (KeyValuePair<Type, string> module in registeredModules)
            {
                RemoveDatabaseTable(module.Key);
            }
        }

        public override async Task<bool> AddItemIntoDatabase<T>(T newItem)
        {
            ObservableCollection<T> allItems = GetAllItems<T>();

            StorageChange addStorageChange = new StorageChange()
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
                allItems.Add(newItem);
                string tableName = registeredModules[typeof(T)];
                return await SaveFileAsync(allItems, tableName);
            }
        }

        public override void CreateDatabaseTable(Type tableType)
        {
            string tableName = registeredModules[tableType];

            if (tableName == null)
                throw new Base.Exceptions.ArgumentException("Module is not registered");

            try
            {
                using (FileStream file = File.Create($@"{connectionsString}\{tableName}.xml"))
                {

                }
            }
            catch (Exception e)
            {
                throw new Base.Exceptions.Exception("Unhandled exception", e);
            }
        }

        public override ObservableCollection<T> GetAllItems<T>()
        {
            if (useInMemoryCache)
                return (ObservableCollection<T>)inMemoryCache[typeof(T)].Cast<T>();

            string tableName = registeredModules[typeof(T)];
            return ReadFileAsync<T>(tableName).Result;
        }

        /// <summary>
        /// Read data from file
        /// </summary>
        /// <param name="Attempts">Number of attempts</param>
        /// <returns>Collection of items of type T</returns>
        protected async Task<ObservableCollection<T>> ReadFileAsync<T>(string tableName, int Attempts = 0) where T : BaseItem
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ItemStorage<T>));
                Stream xmlStream = File.OpenRead($@"{connectionsString}\{tableName}.xml");

                object readedObjects;
                using (xmlStream)
                {
                    readedObjects = (ItemStorage<T>)serializer.Deserialize(xmlStream);
                }

                if (readedObjects != null)
                {

                    return ((ItemStorage<T>)readedObjects).Items;
                }

                return new ObservableCollection<T>();
            }

            // When is file unavailable - 10 attempts is enough
            catch (Exception e) when (e.Message.Contains("denied") && Attempts < 10)
            {
                LogService.AddLogMessage(e.Message);
                return await ReadFileAsync<T>(tableName, Attempts + 1);
            }

            catch (Exception e)
            {
                return new ObservableCollection<T>();
                //throw new Base.Exceptions.Exception("Unhandled exception", e);
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
                string typeOfItem = nameof(T);

                ItemStorage<T> itemStorage = new ItemStorage<T>()
                {
                    Items = itemsToSave,
                    TypeOfItem = typeOfItem
                };

                XmlSerializer Serializ = new XmlSerializer(typeof(ItemStorage<T>));

                using (Stream XmlStream = File.OpenWrite($@"{connectionsString}\{tableName}.xml"))
                {
                    Serializ.Serialize(XmlStream, itemStorage);
                }

                return true;
            }

            // When file is unavailable
            catch (Exception e) when ((e.Message.Contains("denied") || e.Message.Contains("is in use")) && Attempts < 10)
            {
                LogService.AddLogMessage(e.Message);
                return await SaveFileAsync(itemsToSave, tableName, Attempts + 1);
            }

            catch (Exception e)
            {
                return default;
                //throw new Base.Exceptions.Exception("Unhandled exception", e);
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

        public override void RemoveDatabaseTable(Type tableType)
        {
            string tableName = registeredModules[tableType];

            if (tableName == null)
                throw new Base.Exceptions.ArgumentException("Module is not registered");

            if (File.Exists($@"{connectionsString}\{tableName}.xml"))
                File.Delete($@"{connectionsString}\{tableName}.xml");
        }

        public override async Task<bool> RemoveRow<T>(int ID)
        {
            if (useInMemoryCache)
            {
                ObservableCollection<BaseItem> allItems = inMemoryCache[typeof(T)];
                BaseItem itemToRemove = allItems.FirstOrDefault(x => x.ID == ID);

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
                ObservableCollection<T> allItems = GetAllItems<T>();
                T itemToRemove = allItems.FirstOrDefault(x => x.ID == ID);

                if (itemToRemove != null)
                {
                    allItems.Remove(itemToRemove);
                    string tableName = registeredModules[typeof(T)];

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
                string tableName = registeredModules[typeof(T)];
                await SaveFileAsync(source, tableName);
            }
        }

        public override void UpdateDatabaseTable(Type tableType)
        {
            RemoveDatabaseTable(tableType);
            CreateDatabaseTable(tableType);
        }

        public override async Task<bool> UpdateItem<T>(T updateItem)
        {
            if (useInMemoryCache)
            {
                ObservableCollection<BaseItem> allItems = inMemoryCache[typeof(T)];
                BaseItem itemToUpdate = allItems.FirstOrDefault(x => x.ID == updateItem.ID);
                int itemToUpdateIndex = allItems.IndexOf(itemToUpdate);

                allItems[itemToUpdateIndex] = updateItem;
                return true;
            }
            else
            {
                ObservableCollection<T> allItems = GetAllItems<T>();
                T itemToUpdate = allItems.FirstOrDefault(x => x.ID == updateItem.ID);
                int itemToUpdateIndex = allItems.IndexOf(itemToUpdate);
                string tableName = registeredModules[typeof(T)];

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
            ObservableCollection<BaseItem> itemsToSave = inMemoryCache[typeof(T)];
            string tableName = registeredModules[typeof(T)];

            await SaveFileAsync(itemsToSave, tableName);
        }

        public override async Task ClearChangesInMemoryCache<T>()
        {
            await ReloadInMemoryCache<T>(false);
        }

        public override async Task<ObservableCollection<T>> ReloadInMemoryCache<T>(bool writeChangesIntoFB)
        {
            ObservableCollection<BaseItem> itemsToSave = inMemoryCache[typeof(T)];
            string tableName = registeredModules[typeof(T)];

            await SaveFileAsync(itemsToSave, tableName);

            return await ReadFileAsync<T>(tableName);
        }
    }
}
