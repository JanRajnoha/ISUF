using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Interface
{
    public interface IDatabaseAccess
    {
        void RegisterModule(Type moduleType, string tableName);

        void CreateDatabase();

        void UpdateDatabase();

        void RemoveDatabase();

        void UpdateDatabaseTable(string tableName, Type tableType);

        void CreateDatabaseTable(string tableName, Type tableType);

        void RemoveDatabaseTable(string tableName);

        ObservableCollection<T> GetAllItems<T>() where T : BaseItem;

        T GetItem<T>(int ID) where T : BaseItem;

        Task<bool> UpdateItem<T>(T updateItem) where T : BaseItem;

        Task<bool> AddItemIntoDatabase<T>(T newItem) where T : BaseItem;

        void RemoveAllRows();

        Task<bool> RemoveRow<T>(int ID) where T : BaseItem;

        bool IsItemInDatabase<T>(int ID) where T : BaseItem;

        bool IsItemInDatabase<T>(T x) where T : BaseItem;

        Task WriteInMemoryCache<T>() where T : BaseItem;

        Task ClearChangesInMemoryCache<T>() where T : BaseItem;

        Task<ObservableCollection<T>> ReloadInMemoryCache<T>(bool writeChangesIntoDB) where T : BaseItem;

        bool HasInMemoryCacheItem<T>() where T : BaseItem;

        bool CreateInMemoryCacheItem<T>() where T : BaseItem;
    }
}
