using ISUF.Base.Modules;
using ISUF.Storage.Modules;
using System;
using System.Collections.Generic;

namespace ISUF.UI.Modules
{
    /// <summary>
    /// UI module manager
    /// </summary>
    public class UIModuleManager : StorageModuleManager
    {
        /// <summary>
        /// Init UI module manager
        /// </summary>
        /// <param name="dbAccessType">Database access type</param>
        /// <param name="connectionString">Connection string</param>
        /// <param name="useCache">Write records itno memory</param>
        public UIModuleManager(Type dbAccessType, string connectionString = "", bool useCache = false) : base(dbAccessType, connectionString, useCache)
        {
        }

        /// <summary>
        /// Get all UI modules
        /// </summary>
        /// <returns>List of UI modules</returns>
        public List<AppModuleItem> GetUIModules()
        {
            List<AppModuleItem> uiModules = new List<AppModuleItem>();

            foreach (var module in registeredModules)
            {
                if (module is UIModule uiModule)
                {
                    uiModules.Add(new AppModuleItem(uiModule.ModuleDisplayName, uiModule.ModulePage, uiModule.ModuleIcon));
                }
            }

            return uiModules;
        }
    }
}
