using ISUF.Base.Modules;
using ISUF.Storage.Modules;
using System;
using System.Collections.Generic;

namespace ISUF.UI.Modules
{
    public class UIModuleManager : StorageModuleManager
    {
        public UIModuleManager(Type dbAccessType, string connectionString = "", bool useCache = false) : base(dbAccessType, connectionString, useCache)
        {
        }

        public List<AppModuleItem> GetUIModules()
        {
            List<AppModuleItem> uiModules = new List<AppModuleItem>();

            foreach (var module in registeredModules)
            {
                if (module is UIModule uiModule)
                {
                    uiModules.Add(new AppModuleItem(uiModule.ModuleName,uiModule.ModulePage, uiModule.ModuleIcon));
                }
            }

            return uiModules;
        }
    }
}
