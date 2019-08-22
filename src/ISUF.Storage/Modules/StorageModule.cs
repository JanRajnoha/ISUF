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

        private IDatabaseAccess dbAccess;

        public IDatabaseAccess DbAccess
        {
            get => dbAccess;
            set
            {
                dbAccess = value;
                CreateItemManager();
            }
        }

        // TODO: Přidat init možnost na zadání tableName
        public StorageModule(Type moduleItemType, Type itemManagerType) : base(moduleItemType)
        {
            this.itemManagerType = itemManagerType;
        }

        public StorageModule(Type moduleItemType, string moduleName, Type itemManagerType) : base(moduleItemType, moduleName)
        {
            this.itemManagerType = itemManagerType;
        }

        private void CreateItemManager()
        {
            ItemManager = (IItemManager)Activator.CreateInstance(itemManagerType, DbAccess, moduleItemType, moduleName);
        }
    }
}
