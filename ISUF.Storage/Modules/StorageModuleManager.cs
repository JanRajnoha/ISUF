using ISUF.Base.Template;
using ISUF.Interface;
using ISUF.Base.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Modules
{
    public partial class StorageModuleManager : ModuleManager
    {
        public IDatabaseAccess DbAccess { get; set; }

        public StorageModuleManager(Type dbAccessType) : base()
        {
            CreateDbAccess(dbAccessType);
        }

        private void CreateDbAccess(Type dbAccessType)
        { 
            DbAccess = (IDatabaseAccess)Activator.CreateInstance(dbAccessType, "test.xml", false);
        }

        public override bool RegisterModule(Module module)
        {
            var storageModule = (StorageModule)module;
            storageModule.DbAccess = DbAccess;

            return base.RegisterModule(module);
        }
    }
}