using ISUF.Base.Template;
using ISUF.Interface;
using ISUF.Base.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Modules
{
    public partial class StorageModuleManager : ModuleManager
    {
        private IDatabaseAccess dbAccess;

        public StorageModuleManager(Type dbAccessType, string connectionString = "", bool useCache = false) : base()
        {
            CreateDbAccess(dbAccessType, connectionString, useCache);
        }

        private void CreateDbAccess(Type dbAccessType, string connectionString, bool useCache)
        {
            dbAccess = (IDatabaseAccess)Activator.CreateInstance(dbAccessType, connectionString, useCache);
        }

        public override bool RegisterModule(Module module)
        {
            var storageModule = (StorageModule)module;
            storageModule.DbAccess = dbAccess;

            return base.RegisterModule(module);
        }

        public void CreateDatabase()
        {
            dbAccess.CreateDatabase();
        }

        public void UpdateDatabase()
        {
            dbAccess.UpdateDatabase();
        }

        public void RemoveDatabase()
        {
            dbAccess.RemoveDatabase();
        }
    }
}