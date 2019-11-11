using ISUF.Storage.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Modules
{
    public class UIModule : StorageModule
    {
        public Symbol ModuleIcon { get; private set; }
        public string ModuleDisplayName { get; private set; }
        public Type ModulePage { get; private set; }

        public UIModule(Type moduleItemType, Type itemManagerType, string moduleDisplayName, Symbol moduleIcon, Type modulePage, string moduleTableName = null) : base(moduleItemType, itemManagerType, moduleTableName)
        {
            SetModuleInfo(moduleDisplayName, moduleIcon, modulePage);
        }

        public UIModule(Type moduleItemType, string moduleName, Type itemManagerType, string moduleDisplayName,
                        Symbol moduleIcon, Type modulePage, string moduleTableName = null) : base(moduleItemType, moduleName, itemManagerType, moduleTableName)
        {
            SetModuleInfo(moduleDisplayName, moduleIcon, modulePage);
        }

        private void SetModuleInfo(string moduleDisplayName, Symbol moduleIcon, Type modulePage)
        {
            ModuleIcon = moduleIcon;
            ModuleDisplayName = moduleDisplayName;
            ModulePage = modulePage;
        }
    }
}
