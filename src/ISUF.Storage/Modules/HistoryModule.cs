using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Modules
{
    class HistoryModule : StorageModule
    {
        public HistoryModule(Type moduleItemType, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, itemManagerType, moduleTableName)
        {
        }

        public HistoryModule(Type moduleItemType, string moduleName, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, moduleName, itemManagerType, moduleTableName)
        {
        }
    }
}
