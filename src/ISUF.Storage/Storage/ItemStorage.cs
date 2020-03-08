using ISUF.Base.Template;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ISUF.Storage.Storage
{
    public class ItemStorage<T> where T : AtomicItem
    {
        public string TypeOfItem { get; set; }

        public List<T> Items { get; set; } = new List<T>();
    }
}

