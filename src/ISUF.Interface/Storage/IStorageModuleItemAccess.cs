using ISUF.Base.Template;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ISUF.Interface.Storage
{
    public interface IStorageModuleItemAccess
    {
        T GetItemById<T>(int id) where T : AtomicItem;
        bool AddItem<T>(T newItem, bool ignoreLinkedTableUpdate = false) where T : AtomicItem;
        bool RemoveItemById<T>(int id) where T : AtomicItem;
        List<T> GetAllItems<T>() where T : AtomicItem;
        bool EditItem<T>(T editedItem) where T : AtomicItem;
    }
}
