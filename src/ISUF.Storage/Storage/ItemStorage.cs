using ISUF.Base.Template;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ISUF.Storage.Storage
{
    /// <summary>
    /// Model for storing data for sharing
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ItemStorage<T> where T : AtomicItem
    {
        public string TypeOfItem { get; set; }

        public List<T> Items { get; set; } = new List<T>();
    }
}

