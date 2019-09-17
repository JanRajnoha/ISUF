using ISUF.Base.Settings;
using ISUF.Base.Template;
using ISUF.Interface;
using ISUF.Storage.Enum;
using ISUF.Storage.Storage;
using ISUF.Storage.Templates;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ISUF.Storage.DatabaseAccess
{
    public abstract class DatabaseAccess : IDatabaseAccess
    {
        protected string connectionsString;
        protected bool useInMemoryCache;
        protected Dictionary<Type, ObservableCollection<BaseItem>> inMemoryCache = new Dictionary<Type, ObservableCollection<BaseItem>>();
        protected Dictionary<Type, string> registeredModules = new Dictionary<Type, string>();
        protected List<StorageChange> dbChanges = new List<StorageChange>();
        protected Type historyModuleType;
        protected Type userModuleType;

        public DatabaseAccess(string connectionString, bool useInMemoryCache = false)
        {
            if (!CheckConnectionString(connectionString))
                throw new Base.Exceptions.ArgumentException("Connection string is not valid.");

            connectionsString = connectionString;
            this.useInMemoryCache = useInMemoryCache;
        }

        public void RegisterModule(Type moduleType, string tableName)
        {
            if (!registeredModules.ContainsKey(moduleType))
                registeredModules.Add(moduleType, tableName);
            else
                throw new Base.Exceptions.ArgumentException("Module with this name is already registered.");
        }

        public abstract void CreateDatabase();

        public abstract void UpdateDatabase();

        public abstract void RemoveDatabase();

        public abstract bool CheckConnectionString(string connectionString);

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

        public abstract ObservableCollection<T> GetAllItems<T>() where T : BaseItem;

        public abstract T GetItem<T>(int ID) where T : BaseItem;

        public virtual async Task<bool> EditItemInDatabase<T>(T editedItem) where T : BaseItem
        {
            StorageChange editStorageChange = new StorageChange()
            {
                ID = editedItem.ID,
                TypeOfChange = DbTypeOfChange.Edit,
                ModuleType = typeof(T),
                InMemoryChange = useInMemoryCache,
                ChangeSaved = !useInMemoryCache,
            };

            dbChanges.Add(editStorageChange);

            return true;
        }

        public virtual async Task<bool> AddItemIntoDatabase<T>(T newItem) where T : BaseItem
        {
            StorageChange addStorageChange = new StorageChange()
            {
                ID = newItem.ID,
                TypeOfChange = DbTypeOfChange.Add,
                ModuleType = typeof(T),
                InMemoryChange = useInMemoryCache,
                ChangeSaved = !useInMemoryCache,
            };

            dbChanges.Add(addStorageChange);

            return true;
        }

        public abstract void RemoveAllItemsFromDatabase();

        public virtual async Task<bool> RemoveItemFromDatabase<T>(int ID) where T : BaseItem
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

        public abstract bool IsItemInDatabase<T>(int ID) where T : BaseItem;

        /// <summary>
        /// Check, if item exist in collection
        /// </summary>
        /// <param name="x">Check item</param>
        /// <returns>True, if exist</returns>
        public virtual bool IsItemInDatabase<T>(T x) where T : BaseItem
        {
            if (useInMemoryCache)
                return inMemoryCache[typeof(T)].Contains(x);
            else
                return IsItemInDatabase<T>(x.ID);
        }

        public abstract Task WriteInMemoryCache<T>() where T : BaseItem;

        public abstract Task ClearChangesInMemoryCache<T>() where T : BaseItem;

        public abstract Task<ObservableCollection<T>> ReloadInMemoryCache<T>(bool writeChangesIntoFB) where T : BaseItem;

        public abstract Task SetSourceCollection<T>(ObservableCollection<T> source) where T : BaseItem;

        /// <summary>
        /// Get true/false statement for filtering items based on security
        /// </summary>
        /// <param name="x">Type of item</param>
        /// <returns>Result of logic. expression</returns>
        protected virtual bool GetValidItems<T>(T x) where T : BaseItem
        {
            bool userLogged = CustomSettings.IsUserLogged;

            return x.Secured == userLogged || (x.Secured != userLogged && userLogged == true);
        }

        public bool HasInMemoryCacheItem<T>() where T : BaseItem
        {
            return inMemoryCache.ContainsKey(typeof(T));
        }

        public bool CreateInMemoryCacheItem<T>() where T : BaseItem
        {
            if (!HasInMemoryCacheItem<T>())
            {
                inMemoryCache.Add(typeof(T), (ObservableCollection<BaseItem>)new ObservableCollection<T>().Cast<BaseItem>());
                return true;
            }
            else
                return false;
        }

        public void RegisterUserModule(Type userModuleType)
        {
            if (this.userModuleType != null)
                throw new Base.Exceptions.ArgumentException($"User module was defined. Defined user module: {this.userModuleType.Name}");

            this.userModuleType = userModuleType;
        }

        public void RegisterHistoryModule(Type historyModuleType, IItemManager historyManager)
        {
            if (this.historyModuleType != null)
                throw new Base.Exceptions.ArgumentException($"History module was defined. Defined hisory module: {this.historyModuleType.Name}");

            this.historyModuleType = historyModuleType;
        }

        //public abstract void WriteHistory();
    }
}
