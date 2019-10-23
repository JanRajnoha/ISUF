using ISUF.Storage.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.UI.Modules
{
    public class UIModule : StorageModule
    {
        public string ModuleIcon { get; private set; }
        public string ModuleDisplayName { get; private set; }

        public UIModule(Type moduleItemType, Type itemManagerType, string moduleDisplayName, string moduleIcon, string moduleTableName = null) : base(moduleItemType, itemManagerType, moduleTableName)
        {
            SetModuleInfo(moduleDisplayName, moduleIcon);
        }

        public UIModule(Type moduleItemType, string moduleName, Type itemManagerType, string moduleDisplayName, string moduleIcon, string moduleTableName = null) : base(moduleItemType, moduleName, itemManagerType, moduleTableName)
        {
            SetModuleInfo(moduleDisplayName, moduleIcon);
        }

        private void SetModuleInfo(string moduleDisplayName, string moduleIcon)
        {
            ModuleIcon = moduleIcon;
            ModuleDisplayName = moduleDisplayName;
        }
    }
}
