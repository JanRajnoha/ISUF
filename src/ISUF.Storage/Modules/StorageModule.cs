using ISUF.Base.Modules;
using ISUF.Base.Template;
using ISUF.Interface;
using ISUF.Storage.DatabaseAccess;
using ISUF.Storage.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Modules
{
    public class StorageModule : Module
    {
        protected Type itemManagerType;

        public IItemManager ItemManager { get; set; }

        protected IDatabaseAccess dbAccess;
        protected string moduleTableName;

        public IDatabaseAccess DbAccess
        {
            get => dbAccess;
            set
            {
                dbAccess = value;
                CreateItemManager();
            }
        }
        
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

        private void CreateItemManager()
        {
            ItemManager = (IItemManager)Activator.CreateInstance(itemManagerType, DbAccess, moduleItemType, moduleName);
        }
    }
}
