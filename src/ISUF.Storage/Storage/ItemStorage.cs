using ISUF.Base.Template;
using System.Collections.ObjectModel;

namespace ISUF.Storage.Storage
{
    public class ItemStorage<T> where T : AtomicItem
    {
        public string TypeOfItem { get; set; }

        public ObservableCollection<T> Items { get; set; } = new ObservableCollection<T>();
    }
}

