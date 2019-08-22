using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ISUF.Storage.Interface
{
    public interface IItemManager<T>
    {
        Task<bool> AddItem(T item, bool saveData);

        bool AddItemAdditionCheck(T item);

        Task<bool> AddItemRange(List<T> item, bool reloadSource = true, bool CheckItems = true);

        Task<List<string>> GetItemsNameList();

        int IndexOfItem(T examinedItem);

        int IndexOfItem(int ID);

        void Delete(T detailedItem);

        T GetItem(int ID);

        Task<ObservableCollection<T>> GetItemsAsync(bool SecureChanged = false);

        Task SaveChangesAsync();
    }
}
