using ISUF.Storage.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Modules
{
    public class LogUserModule : StorageModule
    {

        public LogUserModule(Type moduleItemType, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, itemManagerType, moduleTableName)
        {
        }

        public LogUserModule(Type moduleItemType, string moduleName, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, moduleName, itemManagerType, moduleTableName)
        {
        }

        public void LogUserActivity(LogUserActivityItem logitem)
        {
            itemManager.AddItem(logitem, moduleManager);
        }
    }
}
