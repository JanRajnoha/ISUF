using ISUF.Base.Modules;
using System;
using ISUF.Interface.Storage;
using Windows.Storage;

namespace ISUF.Storage.Modules
{
    public partial class StorageModuleManager : ModuleManager
    {
        protected IDatabaseAccess dbAccess;

        public StorageModuleManager(Type dbAccessType, string connectionString = "", bool useCache = false) : base()
        {
            if (string.IsNullOrEmpty(connectionString))
                connectionString = ApplicationData.Current.LocalFolder.Path;

            CreateDbAccess(dbAccessType, connectionString, useCache);
        }

        private void CreateDbAccess(Type dbAccessType, string connectionString, bool useCache)
        {
            dbAccess = (IDatabaseAccess)Activator.CreateInstance(dbAccessType, connectionString, useCache);
        }

        public override bool RegisterModule(Module module)
        {
            var storageModule = (StorageModule)module;
            storageModule.SetDbAccess(dbAccess);

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