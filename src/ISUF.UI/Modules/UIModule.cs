using ISUF.Interface.Storage;
using ISUF.Storage.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Modules
{
    /// <summary>
    /// UI Module
    /// </summary>
    public class UIModule : StorageModule
    {
        protected new IBaseItemManager itemManager;
            
        public string ModuleDisplayName { get; private set; }
        public Symbol ModuleIcon { get; private set; }
        public Type ModulePage { get; private set; }

        /// <summary>
        /// Init UI module
        /// </summary>
        /// <param name="moduleItemType">Module item type</param>
        /// <param name="itemManagerType">Itemmanager type</param>
        /// <param name="moduleDisplayName">Module display name</param>
        /// <param name="moduleIcon">Module icon</param>
        /// <param name="modulePage">Module page</param>
        /// <param name="moduleTableName">Module table name</param>
        public UIModule(Type moduleItemType, Type itemManagerType, string moduleDisplayName, Symbol moduleIcon, Type modulePage, string moduleTableName = null) : base(moduleItemType, itemManagerType, moduleTableName)
        {
            SetModuleInfo(moduleDisplayName, moduleIcon, modulePage);
        }

        /// <summary>
        /// Init UI module
        /// </summary>
        /// <param name="moduleItemType">Module item type</param>
        /// <param name="moduleName">Module name</param>
        /// <param name="itemManagerType">Itemmanager type</param>
        /// <param name="moduleDisplayName">Module display name</param>
        /// <param name="moduleIcon">Module icon</param>
        /// <param name="modulePage">Module page</param>
        /// <param name="moduleTableName">Module table name</param>
        public UIModule(Type moduleItemType, string moduleName, Type itemManagerType, string moduleDisplayName,
                        Symbol moduleIcon, Type modulePage, string moduleTableName = null) : base(moduleItemType, moduleName, itemManagerType, moduleTableName)
        {
            SetModuleInfo(moduleDisplayName, moduleIcon, modulePage);
        }

        /// <summary>
        /// Set module info
        /// </summary>
        /// <param name="moduleDisplayName">Module display name</param>
        /// <param name="moduleIcon">Module icon</param>
        /// <param name="modulePage">Module page</param>
        private void SetModuleInfo(string moduleDisplayName, Symbol moduleIcon, Type modulePage)
        {
            ModuleIcon = moduleIcon;
            ModuleDisplayName = moduleDisplayName;
            ModulePage = modulePage;
        }
    }
}
