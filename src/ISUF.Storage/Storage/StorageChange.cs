using ISUF.Storage.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Storage
{
    public class StorageChange
    {
        public int ID { get; set; }

        public DbTypeOfChange TypeOfChange { get; set; }

        public Type ModuleType { get; set; }

        public bool InMemoryChange { get; set; }

        public bool ChangeSaved { get; set; }
    }
}
