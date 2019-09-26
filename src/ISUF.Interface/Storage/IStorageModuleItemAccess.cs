using ISUF.Base.Template;
using System.Collections.ObjectModel;

namespace ISUF.Interface.Storage
{
    public interface IStorageModuleItemAccess
    {
        T GetItemById<T>(int id) where T : AtomicItem;
        bool AddItem<T>(T newItem) where T : AtomicItem;
        bool RemoveItemById(int id);
        ObservableCollection<T> GetAllItems<T>() where T : AtomicItem;
        bool EditItem<T>(T editedItem) where T : AtomicItem;
    }
}
