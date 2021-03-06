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
    /// <summary>
    /// XML Database access
    /// </summary>
    public class XmlDbAccess : DatabaseAccess
    {
        /// <summary>
        /// Initial of XML database access
        /// </summary>
        /// <param name="connectionString">Connection string for database</param>
        /// <param name="useChache">Write records into memory</param>
        public XmlDbAccess(string connectionString, bool useChache) : base(connectionString, useChache)
        {
        }

        /// <summary>
        /// Initial of XML database access
        /// </summary>
        /// <param name="useChache">Write records into memory</param>
        public XmlDbAccess(bool useChache) : base(ApplicationData.Current.LocalFolder.ToString(), useChache)
        {
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public override void CreateDatabase()
        {
            foreach (KeyValuePair<Type, string> module in registeredModules)
            {
                CreateDatabaseTable(module.Key);
            }
        }

        /// <inheritdoc/>
        public override void UpdateDatabase()
        {
            foreach (KeyValuePair<Type, string> module in registeredModules)
            {
                UpdateDatabaseTable(module.Key);
            }
        }

        /// <inheritdoc/>
        public override void RemoveDatabase()
        {
            foreach (KeyValuePair<Type, string> module in registeredModules)
            {
                RemoveDatabaseTable(module.Key);
            }
        }

        /// <inheritdoc/>
        public override async Task<bool> AddItemIntoDatabase<T>(T newItem)
        {
            base.AddItemIntoDatabase(newItem);

            List<T> allItems = GetAllItems<T>();

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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public override List<T> GetAllItems<T>()
        {
            if (useInMemoryCache)
                return (List<T>)inMemoryCache[typeof(T)].Cast<T>();

            string tableName = registeredModules[typeof(T)];
            return ReadFileAsync<T>(tableName).Result;
        }

        /// <summary>
        /// Read data from file
        /// </summary>
        /// <param name="Attempts">Number of attempts</param>
        /// <returns>Collection of items of type T</returns>
        protected async Task<List<T>> ReadFileAsync<T>(string tableName, int Attempts = 0) where T : AtomicItem
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ItemStorage<T>));

                object readedObjects;
                using (Stream xmlStream = File.Open($@"{connectionsString}\{tableName}.xml", FileMode.OpenOrCreate))
                {
                    if (xmlStream.Length == 0)
                        return new List<T>();

                    readedObjects = (ItemStorage<T>)serializer.Deserialize(xmlStream);
                }

                if (readedObjects != null)
                {
                    return ((ItemStorage<T>)readedObjects).Items;
                }

                return new List<T>();
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
        protected async Task<bool> SaveFileAsync<T>(List<T> itemsToSave, string tableName, int Attempts = 0) where T : AtomicItem
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

        /// <inheritdoc/>
        public override T GetItem<T>(int ID)
        {
            return GetAllItems<T>().FirstOrDefault(x => x.Id == ID);
        }

        /// <inheritdoc/>
        public override bool IsItemInDatabase<T>(int ID)
        {
            return GetItem<T>(ID) != null;
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public override void RemoveDatabaseTable(Type tableType)
        {
            base.RemoveDatabaseTable(tableType);

            string tableName = registeredModules[tableType];

            if (tableName == null)
                throw new Base.Exceptions.ArgumentException("Module is not registered");

            if (File.Exists($@"{connectionsString}\{tableName}.xml"))
                File.Delete($@"{connectionsString}\{tableName}.xml");
        }

        /// <inheritdoc/>
        public override async Task<bool> RemoveItemFromDatabase<T>(int ID)
        {
            base.RemoveItemFromDatabase<T>(ID);

            if (useInMemoryCache)
            {
                List<AtomicItem> allItems = inMemoryCache[typeof(T)];
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
                List<T> allItems = GetAllItems<T>();
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

        /// <inheritdoc/>
        public override async Task SetSourceCollection<T>(List<T> source)
        {
            if (useInMemoryCache)
            {
                inMemoryCache[typeof(T)] = (List<AtomicItem>)source.Cast<AtomicItem>();
            }
            else
            {
                string tableName = registeredModules[typeof(T)];
                await SaveFileAsync(source, tableName);
            }
        }

        /// <inheritdoc/>
        public override void UpdateDatabaseTable(Type tableType)
        {
            base.UpdateDatabaseTable(tableType);

            RemoveDatabaseTable(tableType);
            CreateDatabaseTable(tableType);
        }

        /// <inheritdoc/>
        public override async Task<bool> EditItemInDatabase<T>(T editedItem)
        {
            base.EditItemInDatabase(editedItem);

            if (useInMemoryCache)
            {
                List<AtomicItem> allItems = inMemoryCache[typeof(T)];
                AtomicItem itemToUpdate = allItems.FirstOrDefault(x => x.Id == editedItem.Id);
                int itemToUpdateIndex = allItems.IndexOf(itemToUpdate);

                allItems[itemToUpdateIndex] = editedItem;
                return true;
            }
            else
            {
                List<T> allItems = GetAllItems<T>();
                T itemToUpdate = allItems.FirstOrDefault(x => x.Id == editedItem.Id);
                int itemToUpdateIndex = allItems.IndexOf(itemToUpdate);
                string tableName = registeredModules[typeof(T)];

                allItems[itemToUpdateIndex] = editedItem;
                return await SaveFileAsync(allItems, tableName);
            }
        }

        /// <inheritdoc/>
        public override async Task WriteInMemoryCache<T>()
        {
            List<AtomicItem> itemsToSave = inMemoryCache[typeof(T)];
            string tableName = registeredModules[typeof(T)];

            await SaveFileAsync(itemsToSave, tableName);
        }

        /// <inheritdoc/>
        public override async Task ClearChangesInMemoryCache<T>()
        {
            await ReloadInMemoryCache<T>(false);
        }

        /// <inheritdoc/>
        public override async Task<List<T>> ReloadInMemoryCache<T>(bool writeChangesIntoFB)
        {
            List<AtomicItem> itemsToSave = inMemoryCache[typeof(T)];
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
