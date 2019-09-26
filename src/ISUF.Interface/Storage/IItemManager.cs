using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Interface.Storage
{
    public interface IItemManager
    {
        bool AddItem<T>(T item) where T : BaseItem;

        bool AddItemAdditionCheck<T>(T item) where T : BaseItem;

        Task<bool> AddItemRange<T>(List<T> item, bool checkItems = true) where T : BaseItem;

        List<string> GetItemsNameList<T>() where T : BaseItem;

        Task<ObservableCollection<T>> GetAllItems<T>() where T : BaseItem;

        Task<bool> RemoveItem<T>(T detailedItem) where T : BaseItem;

        Task<bool> RemoveItem<T>(int id) where T : BaseItem;

        T GetItem<T>(int ID) where T : BaseItem;

        void UpdateDatabaseTable();

        void CreateDatabaseTable();

        void RemoveDatabaseTable();
    }
}
