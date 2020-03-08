using ISUF.Base.Template;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ISUF.Interface.Storage
{
    public interface IStorageModuleStorageAccess
    {
        bool SaveInMemoryChanges();

        bool AddItem(object item);

        bool RemoveItem(int ID);

        bool UpdateItem(object item);

        List<T> GetAllItems<T>() where T : AtomicItem;

        T GetItem<T>(int ID) where T : AtomicItem;

        bool RemoveAllItems();
    }
}
