using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Interface.Storage
{
    public interface IDatabaseAccess
    {
        void RegisterModule(Type moduleType, string tableName);

        void CreateDatabase();

        void UpdateDatabase();

        void RemoveDatabase();

        void UpdateDatabaseTable(Type tableType);

        void CreateDatabaseTable(Type tableType);

        void RemoveDatabaseTable(Type tableType);

        ObservableCollection<T> GetAllItems<T>() where T : AtomicItem;

        T GetItem<T>(int ID) where T : AtomicItem;

        Task<bool> EditItemInDatabase<T>(T editedItem) where T : AtomicItem;

        Task<bool> AddItemIntoDatabase<T>(T newItem) where T : AtomicItem;

        void RemoveAllItemsFromDatabase();

        Task<bool> RemoveItemFromDatabase<T>(int ID) where T : AtomicItem;

        bool IsItemInDatabase<T>(int ID) where T : AtomicItem;

        bool IsItemInDatabase<T>(T x) where T : AtomicItem;

        Task WriteInMemoryCache<T>() where T : AtomicItem;

        Task ClearChangesInMemoryCache<T>() where T : AtomicItem;

        Task<ObservableCollection<T>> ReloadInMemoryCache<T>(bool writeChangesIntoDB) where T : AtomicItem;

        bool HasInMemoryCacheItem<T>() where T : AtomicItem;

        bool CreateInMemoryCacheItem<T>() where T : AtomicItem;

        void RegisterUserModule(Type userModuleType);

        void RegisterHistoryModule(Type historyModuleType, IAtomicItemManager historyManager);

        //void WriteHistory();
    }
}
