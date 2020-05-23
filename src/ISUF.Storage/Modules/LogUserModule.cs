using ISUF.Storage.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Modules
{
    /// <summary>
    /// Log user module
    /// </summary>
    public class LogUserModule : StorageModule
    {
        /// <summary>
        /// Init user module
        /// </summary>
        /// <param name="moduleItemType">Item type</param>
        /// <param name="itemManagerType">Item manager</param>
        /// <param name="moduleTableName">Module table name</param>
        public LogUserModule(Type moduleItemType, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, itemManagerType, moduleTableName)
        {
        }

        /// <summary>
        /// Init user module
        /// </summary>
        /// <param name="moduleItemType">Item type</param>
        /// <param name="moduleName">Module name</param>
        /// <param name="itemManagerType">Item manager</param>
        /// <param name="moduleTableName">Module table name</param>
        public LogUserModule(Type moduleItemType, string moduleName, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, moduleName, itemManagerType, moduleTableName)
        {
        }

        /// <summary>
        /// Log user activity
        /// </summary>
        /// <param name="logitem">User log item</param>
        public void LogUserActivity(LogUserActivityItem logitem)
        {
            itemManager.AddItem(logitem, moduleManager);
        }
    }
}
