using ISUF.Base.Template;
using System.Collections.ObjectModel;

namespace ISUF.Interface.Storage
{
    public interface IStorageModuleItemAccess
    {
        T GetItemById<T>(int id) where T : BaseItem;
        bool AddItem<T>(T newItem) where T : BaseItem;
        bool RemoveItemById(int id);
        ObservableCollection<T> GetAllItems<T>() where T : BaseItem;
        bool EditItem<T>(T editedItem) where T : BaseItem;
    }
}
