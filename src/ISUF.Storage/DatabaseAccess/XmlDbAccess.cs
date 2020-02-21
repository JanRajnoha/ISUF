using ISUF.Base.Service;
using ISUF.Base.Template;
using ISUF.Storage.Enum;
using ISUF.Storage.Storage;
using ISUF.Storage.Templates;
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
            base.AddItemIntoDatabase(newItem);

            ObservableCollection<T> allItems = GetAllItems<T>();

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
            base.CreateDatabaseTable(tableType);

            string tableName = registeredModules[tableType];

            if (tableName == null)
                throw new Base.Exceptions.ArgumentException("Module is not registered");

            try
            {
                using FileStream file = File.Create($@"{connectionsString}\{tableName}.xml");
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
        protected async Task<ObservableCollection<T>> ReadFileAsync<T>(string tableName, int Attempts = 0) where T : AtomicItem
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ItemStorage<T>));

                object readedObjects;
                using (Stream xmlStream = File.OpenRead($@"{connectionsString}\{tableName}.xml"))
                {
                    if (xmlStream.Length == 0)
                        return new ObservableCollection<T>();

                    readedObjects = (ItemStorage<T>)serializer.Deserialize(xmlStream);
                }

                if (readedObjects != null)
                {
                    return ((ItemStorage<T>)readedObjects).Items;
                }

                return new ObservableCollection<T>();
            }

            // When is file unavailable - 10 attempts is enough
            catch (Exception e) when (e.Message.Contains("is in use") && Attempts < 10)
            {
                LogService.AddLogMessage("File is in use\n\n" + e.Message);
                return await ReadFileAsync<T>(tableName, Attempts + 1);
            }

            catch (Exception e)
            {
                throw new Base.Exceptions.Exception("Unhandled exception", e);
            }
        }

        /// <summary>
        /// Save data to file
        /// </summary>
        /// <param name="Attempts">Number of attempts</param>
        /// <returns>True, if save was succesful</returns>
        protected async Task<bool> SaveFileAsync<T>(ObservableCollection<T> itemsToSave, string tableName, int Attempts = 0) where T : AtomicItem
        {
            try
            {
                string typeOfItem = nameof(T);

                ItemStorage<T> itemStorage = new ItemStorage<T>
                {
                    Items = itemsToSave,
                    TypeOfItem = typeOfItem
                };

                XmlSerializer serializer = new XmlSerializer(typeof(ItemStorage<T>));

                using (Stream xmlStream = File.Create($@"{connectionsString}\{tableName}.xml"))
                {
                    serializer.Serialize(xmlStream, itemStorage);
                }

                return true;
            }

            // When file is unavailable
            catch (Exception e) when (e.Message.Contains("is in use") && Attempts < 10)
            {
                LogService.AddLogMessage("File is in use\n\n" + e.Message);
                return await SaveFileAsync(itemsToSave, tableName, Attempts + 1);
            }

            catch (Exception e)
            {
                throw new Base.Exceptions.Exception("Unhandled exception", e);
            }
        }

        public override T GetItem<T>(int ID)
        {
            return GetAllItems<T>().FirstOrDefault(x => x.Id == ID);
        }

        public override bool IsItemInDatabase<T>(int ID)
        {
            return GetItem<T>(ID) != null;
        }

        public override void RemoveAllItemsFromDatabase()
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
            base.RemoveDatabaseTable(tableType);

            string tableName = registeredModules[tableType];

            if (tableName == null)
                throw new Base.Exceptions.ArgumentException("Module is not registered");

            if (File.Exists($@"{connectionsString}\{tableName}.xml"))
                File.Delete($@"{connectionsString}\{tableName}.xml");
        }

        public override async Task<bool> RemoveItemFromDatabase<T>(int ID)
        {
            base.RemoveItemFromDatabase<T>(ID);

            if (useInMemoryCache)
            {
                ObservableCollection<AtomicItem> allItems = inMemoryCache[typeof(T)];
                AtomicItem itemToRemove = allItems.FirstOrDefault(x => x.Id == ID);

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
                T itemToRemove = allItems.FirstOrDefault(x => x.Id == ID);

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
                inMemoryCache[typeof(T)] = (ObservableCollection<AtomicItem>)source.Cast<AtomicItem>();
            }
            else
            {
                string tableName = registeredModules[typeof(T)];
                await SaveFileAsync(source, tableName);
            }
        }

        public override void UpdateDatabaseTable(Type tableType)
        {
            base.UpdateDatabaseTable(tableType);

            RemoveDatabaseTable(tableType);
            CreateDatabaseTable(tableType);
        }

        public override async Task<bool> EditItemInDatabase<T>(T editedItem)
        {
            base.EditItemInDatabase(editedItem);

            if (useInMemoryCache)
            {
                ObservableCollection<AtomicItem> allItems = inMemoryCache[typeof(T)];
                AtomicItem itemToUpdate = allItems.FirstOrDefault(x => x.Id == editedItem.Id);
                int itemToUpdateIndex = allItems.IndexOf(itemToUpdate);

                allItems[itemToUpdateIndex] = editedItem;
                return true;
            }
            else
            {
                ObservableCollection<T> allItems = GetAllItems<T>();
                T itemToUpdate = allItems.FirstOrDefault(x => x.Id == editedItem.Id);
                int itemToUpdateIndex = allItems.IndexOf(itemToUpdate);
                string tableName = registeredModules[typeof(T)];

                allItems[itemToUpdateIndex] = editedItem;
                return await SaveFileAsync(allItems, tableName);
            }
        }

        //TODO dopsat historii
        public override async Task WriteInMemoryCache<T>()
        {
            ObservableCollection<AtomicItem> itemsToSave = inMemoryCache[typeof(T)];
            string tableName = registeredModules[typeof(T)];

            await SaveFileAsync(itemsToSave, tableName);
        }

        public override async Task ClearChangesInMemoryCache<T>()
        {
            await ReloadInMemoryCache<T>(false);
        }

        public override async Task<ObservableCollection<T>> ReloadInMemoryCache<T>(bool writeChangesIntoFB)
        {
            ObservableCollection<AtomicItem> itemsToSave = inMemoryCache[typeof(T)];
            string tableName = registeredModules[typeof(T)];

            await SaveFileAsync(itemsToSave, tableName);

            return await ReadFileAsync<T>(tableName);
        }

        //public override async void WriteHistory()
        //{
        //    var historyTableName = registeredModules[historyModuleType];
        //    var allHistoryRecords = await ReadFileAsync<HistoryItem>(historyTableName);

        //    foreach (var historyItem in dbChanges.Where(x => x.ChangeSaved))
        //    {
        //        allHistoryRecords.Add(historyItem);
        //        dbChanges.Remove(historyItem);
        //    }
        //}
    }
}
