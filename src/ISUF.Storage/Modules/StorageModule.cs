using ISUF.Base.Modules;
using ISUF.Interface;
using System;

namespace ISUF.Storage.Modules
{
    public class StorageModule : Module
    {
        protected Type itemManagerType;

        public IItemManager ItemManager { get; set; }

        protected IDatabaseAccess dbAccess;
        protected string moduleTableName;

        public StorageModule(Type moduleItemType, Type itemManagerType, string moduleTableName = null) : base(moduleItemType)
        {
            SetModuleInfo(itemManagerType, moduleTableName);
        }

        public StorageModule(Type moduleItemType, string moduleName, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, moduleName)
        {
            SetModuleInfo(itemManagerType, moduleTableName);
        }

        private void SetModuleInfo(Type itemManagerType, string moduleTableName)
        {
            this.itemManagerType = itemManagerType;
            this.moduleTableName = moduleTableName ?? moduleName;
        }

        private void CreateItemManager() => ItemManager = (IItemManager)Activator.CreateInstance(itemManagerType, dbAccess, moduleItemType, moduleName);

        public void SetDbAccess(IDatabaseAccess dbAccess)
        {
            this.dbAccess = dbAccess;
            CreateItemManager();
        }
    }
}
