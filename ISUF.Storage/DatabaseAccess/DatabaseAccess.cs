using ISUF.Base.Settings;
using ISUF.Base.Template;
using ISUF.Interface;
using ISUF.Storage.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
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

        public DatabaseAccess(string connectionString, bool useInMemoryCache = false)
        {
            if (!CheckConnectionString(connectionString))
                throw new ArgumentException("Connection string is not valid.");

            connectionsString = connectionString;
            this.useInMemoryCache = useInMemoryCache;
        }

        public void RegisterModule(Type moduleType, string tableName)
        {
            if (!registeredModules.ContainsKey(moduleType))
                registeredModules.Add(moduleType, tableName);
        }

        public abstract void CreateDatabase();

        public abstract void UpdateDatabase();

        public abstract void RemoveDatabase();

        public abstract bool CheckConnectionString(string connectionString);

        public abstract void UpdateDatabaseTable(string tableName, Type tableType);

        public abstract void CreateDatabaseTable(string tableName, Type tableType);

        public abstract void RemoveDatabaseTable(string tableName);

        public abstract ObservableCollection<T> GetAllItems<T>() where T : BaseItem;

        public abstract T GetItem<T>(int ID) where T : BaseItem;

        public abstract Task<bool> UpdateItem<T>(T updateItem) where T : BaseItem;

        public abstract Task<bool> AddItemIntoDatabase<T>(T newItem) where T : BaseItem;

        public abstract void RemoveAllRows();

        public abstract Task<bool> RemoveRow<T>(int ID) where T : BaseItem;

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
    }
}
