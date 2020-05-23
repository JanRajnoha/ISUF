using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Interface.Storage
{
    /// <summary>
    /// Database access interface
    /// </summary>
    public interface IDatabaseAccess
    {
        /// <summary>
        /// Check connection string for database
        /// </summary>
        /// <param name="connectionString">Connection string for database</param>
        /// <returns>Result of checking</returns>
        bool CheckConnectionString(string connectionString);

        /// <summary>
        /// Register module for database access
        /// </summary>
        /// <param name="moduleType">Module type</param>
        /// <param name="tableName">Name of table for module</param>
        void RegisterModule(Type moduleType, string tableName);

        /// <summary>
        /// Create database
        /// </summary>
        void CreateDatabase();

        /// <summary>
        /// Update database and tables
        /// </summary>
        void UpdateDatabase();

        /// <summary>
        /// Remove all data from database and database
        /// </summary>
        void RemoveDatabase();

        /// <summary>
        /// Update table in database
        /// </summary>
        /// <param name="tableType">Table type</param>
        void UpdateDatabaseTable(Type tableType);

        /// <summary>
        /// Create table in database
        /// </summary>
        /// <param name="tableType">Table type</param>
        void CreateDatabaseTable(Type tableType);

        /// <summary>
        /// Remove table from database
        /// </summary>
        /// <param name="tableType">Table type</param>
        void RemoveDatabaseTable(Type tableType);

        /// <summary>
        /// Get all items for selected item type
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <returns>All items for selected item</returns>
        List<T> GetAllItems<T>() where T : AtomicItem;

        /// <summary>
        /// Get item by index for selected item type
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="ID">Item index</param>
        /// <returns>Item by index</returns>
        T GetItem<T>(int ID) where T : AtomicItem;

        /// <summary>
        /// Edit item in database for item type
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="editedItem">Edited item</param>
        /// <returns>Success of task</returns>
        Task<bool> EditItemInDatabase<T>(T editedItem) where T : AtomicItem;

        /// <summary>
        /// Add item into database for item type
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="newItem">New item</param>
        /// <returns>Success of task</returns>
        Task<bool> AddItemIntoDatabase<T>(T newItem) where T : AtomicItem;

        /// <summary>
        /// Remove all items from database
        /// </summary>
        void RemoveAllItemsFromDatabase();

        /// <summary>
        /// Remove item from database for item type
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="ID">Item index</param>
        /// <returns>Success of task</returns>
        Task<bool> RemoveItemFromDatabase<T>(int ID) where T : AtomicItem;

        /// <summary>
        /// Check if item is in database
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="ID">Item index</param>
        /// <returns>Item is in database check result</returns>
        bool IsItemInDatabase<T>(int ID) where T : AtomicItem;

        /// <summary>
        /// Check if item is in database
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="item">Item</param>
        /// <returns>Item is in database check result</returns>
        bool IsItemInDatabase<T>(T item) where T : AtomicItem;

        /// <summary>
        /// Write memory from cache to database
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <returns></returns>
        Task WriteInMemoryCache<T>() where T : AtomicItem;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task ClearChangesInMemoryCache<T>() where T : AtomicItem;

        /// <summary>
        /// Reload memory in cache from database
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="writeChangesIntoDB">Before reload write changes into database</param>
        /// <returns>Reloaded items in memory</returns>
        Task<List<T>> ReloadInMemoryCache<T>(bool writeChangesIntoDB) where T : AtomicItem;

        /// <summary>
        /// Check if module is in cache memory registered
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <returns>Result of checking if module is in memory registered</returns>
        bool HasInMemoryCacheItem<T>() where T : AtomicItem;

        /// <summary>
        /// Register module into cache
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <returns>Success of task</returns>
        bool CreateInMemoryCacheItem<T>() where T : AtomicItem;

        /// <summary>
        /// Register user module
        /// </summary>
        /// <param name="userModuleType">Type of user module</param>
        void RegisterUserModule(Type userModuleType);

        /// <summary>
        /// Register history module
        /// </summary>
        /// <param name="historyModuleType">Type of history module</param>
        /// <param name="historyManager">Type of history manager</param>
        void RegisterHistoryModule(Type historyModuleType, IAtomicItemManager historyManager);
    }
}
