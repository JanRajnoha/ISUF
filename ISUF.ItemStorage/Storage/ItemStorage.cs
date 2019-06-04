using ISUF.Base.Template;
using System.Collections.ObjectModel;

namespace ISUF.ItemStorage.Storage
{
    public class ItemStorage<T> where T : BaseItem
    {
        public string TypeOfItem { get; set; }

        public ObservableCollection<T> Items { get; set; } = new ObservableCollection<T>();
    }
}
