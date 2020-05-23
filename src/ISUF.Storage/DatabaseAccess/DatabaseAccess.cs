using ISUF.Base.Settings;
using ISUF.Base.Template;
using ISUF.Storage.Enum;
using ISUF.Interface.Storage;
using ISUF.Storage.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ISUF.Storage.DatabaseAccess
{
    /// <summary>
    /// Database Access abstract class
    /// </summary>
    public abstract class DatabaseAccess : IDatabaseAccess
    {
        protected string connectionsString;
        protected bool useInMemoryCache;
        protected Dictionary<Type, List<AtomicItem>> inMemoryCache = new Dictionary<Type, List<AtomicItem>>();
        protected Dictionary<Type, string> registeredModules = new Dictionary<Type, string>();
        protected List<StorageChange> dbChanges = new List<StorageChange>();
        protected Type historyModuleType;
        protected Type userModuleType;

        /// <summary>
        /// Initial of database access
        /// </summary>
        /// <param name="connectionString">Connection string for database</param>
        /// <param name="useInMemoryCache">Saving records into memory</param>
        public DatabaseAccess(string connectionString, bool useInMemoryCache = false)
        {
            if (!CheckConnectionString(connectionString))
                throw new Base.Exceptions.ArgumentException("Connection string is not valid.");

            connectionsString = connectionString;
            this.useInMemoryCache = useInMemoryCache;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="moduleType"><inheritdoc/></param>
        /// <param name="tableName"><inheritdoc/></param>
        public void RegisterModule(Type moduleType, string tableName)
        {
            if (!registeredModules.ContainsKey(moduleType))
                registeredModules.Add(moduleType, tableName);
            else
                throw new Base.Exceptions.ArgumentException("Module with this name is already registered.");
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public abstract void CreateDatabase();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public abstract void UpdateDatabase();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public abstract void RemoveDatabase();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="connectionString"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public abstract bool CheckConnectionString(string connectionString);

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="tableType"><inheritdoc/></param>
        public virtual void UpdateDatabaseTable(Type tableType)
        {
            StorageChange addStorageChange = new StorageChange()
            {
                ID = -1,
                TypeOfChange = DbTypeOfChange.UpdateTable,
                ModuleType = tableType,
                InMemoryChange = useInMemoryCache,
                ChangeSaved = !useInMemoryCache,
            };

            dbChanges.Add(addStorageChange);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="tableType"><inheritdoc/></param>
        public virtual void CreateDatabaseTable(Type tableType)
        {
            StorageChange addStorageChange = new StorageChange()
            {
                ID = -1,
                TypeOfChange = DbTypeOfChange.CreateTable,
                ModuleType = tableType,
                InMemoryChange = useInMemoryCache,
                ChangeSaved = !useInMemoryCache,
            };

            dbChanges.Add(addStorageChange);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="tableType"><inheritdoc/></param>
        public virtual void RemoveDatabaseTable(Type tableType)
        {
            StorageChange addStorageChange = new StorageChange()
            {
                ID = -1,
                TypeOfChange = DbTypeOfChange.RemoveTable,
                ModuleType = tableType,
                InMemoryChange = useInMemoryCache,
                ChangeSaved = !useInMemoryCache,
            };

            dbChanges.Add(addStorageChange);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <returns><inheritdoc/></returns>
        public abstract List<T> GetAllItems<T>() where T : AtomicItem;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="ID"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public abstract T GetItem<T>(int ID) where T : AtomicItem;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="editedItem"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public virtual async Task<bool> EditItemInDatabase<T>(T editedItem) where T : AtomicItem
        {
            StorageChange editStorageChange = new StorageChange()
            {
                ID = editedItem.Id,
                TypeOfChange = DbTypeOfChange.Edit,
                ModuleType = typeof(T),
                InMemoryChange = useInMemoryCache,
                ChangeSaved = !useInMemoryCache,
            };

            dbChanges.Add(editStorageChange);

            return true;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="newItem"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public virtual async Task<bool> AddItemIntoDatabase<T>(T newItem) where T : AtomicItem
        {
            StorageChange addStorageChange = new StorageChange()
            {
                ID = newItem.Id,
                TypeOfChange = DbTypeOfChange.Add,
                ModuleType = typeof(T),
                InMemoryChange = useInMemoryCache,
                ChangeSaved = !useInMemoryCache,
            };

            dbChanges.Add(addStorageChange);

            return true;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public abstract void RemoveAllItemsFromDatabase();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="ID"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public virtual async Task<bool> RemoveItemFromDatabase<T>(int ID) where T : AtomicItem
        {
            StorageChange removeStorageChange = new StorageChange()
            {
                ID = ID,
                TypeOfChange = DbTypeOfChange.Remove,
                ModuleType = typeof(T),
                InMemoryChange = useInMemoryCache,
                ChangeSaved = !useInMemoryCache,
            };

            dbChanges.Add(removeStorageChange);

            return true;
        }

        //protected abstract  ObservableCollection<T> GetFinalCollection<T>() where T : BaseItem;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="ID"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public abstract bool IsItemInDatabase<T>(int ID) where T : AtomicItem;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="item"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public virtual bool IsItemInDatabase<T>(T item) where T : AtomicItem
        {
            if (useInMemoryCache)
                return inMemoryCache[typeof(T)].Contains(item);
            else
                return IsItemInDatabase<T>(item.Id);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <returns><inheritdoc/></returns>
        public abstract Task WriteInMemoryCache<T>() where T : AtomicItem;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <returns><inheritdoc/></returns>
        public abstract Task ClearChangesInMemoryCache<T>() where T : AtomicItem;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="writeChangesIntoFB"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public abstract Task<List<T>> ReloadInMemoryCache<T>(bool writeChangesIntoFB) where T : AtomicItem;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="source"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public abstract Task SetSourceCollection<T>(List<T> source) where T : AtomicItem;

        /// <summary>
        /// Get true/false statement for filtering items based on security
        /// </summary>
        /// <param name="x">Type of item</param>
        /// <returns>Result of logic. expression</returns>
        protected virtual bool GetValidItems<T>(T x) where T : AtomicItem
        {
            bool userLogged = CustomSettings.IsUserLogged;

            return x.Secured == userLogged || (x.Secured != userLogged && userLogged == true);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <returns><inheritdoc/></returns>
        public bool HasInMemoryCacheItem<T>() where T : AtomicItem
        {
            return inMemoryCache.ContainsKey(typeof(T));
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <returns><inheritdoc/></returns>
        public bool CreateInMemoryCacheItem<T>() where T : AtomicItem
        {
            if (!HasInMemoryCacheItem<T>())
            {
                inMemoryCache.Add(typeof(T), (List<AtomicItem>)new List<T>().Cast<AtomicItem>());
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="userModuleType"><inheritdoc/></param>
        public void RegisterUserModule(Type userModuleType)
        {
            if (this.userModuleType != null)
                throw new Base.Exceptions.ArgumentException($"User module was defined. Defined user module: {this.userModuleType.Name}");

            this.userModuleType = userModuleType;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="historyModuleType"><inheritdoc/></param>
        /// <param name="historyManager"><inheritdoc/></param>
        public void RegisterHistoryModule(Type historyModuleType, IAtomicItemManager historyManager)
        {
            if (this.historyModuleType != null)
                throw new Base.Exceptions.ArgumentException($"History module was defined. Defined hisory module: {this.historyModuleType.Name}");

            this.historyModuleType = historyModuleType;
        }

        //public abstract void WriteHistory();
    }
}
