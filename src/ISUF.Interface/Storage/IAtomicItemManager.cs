using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Interface.Storage
{
    public interface IAtomicItemManager
    {
        bool AddItem<T>(T item) where T : AtomicItem;

        bool AddItemAdditionCheck<T>(T item) where T : AtomicItem;

        Task<bool> AddItemRange<T>(List<T> item, bool checkItems = true) where T : AtomicItem;

        Task<ObservableCollection<T>> GetAllItems<T>() where T : AtomicItem;

        Task<bool> RemoveItem<T>(T detailedItem) where T : AtomicItem;

        Task<bool> RemoveItem<T>(int id) where T : AtomicItem;

        T GetItem<T>(int ID) where T : AtomicItem;

        void UpdateDatabaseTable();

        void CreateDatabaseTable();

        void RemoveDatabaseTable();
    }
}
