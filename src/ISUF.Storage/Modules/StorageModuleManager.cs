using ISUF.Base.Modules;
using System;
using ISUF.Interface.Storage;
using Windows.Storage;

namespace ISUF.Storage.Modules
{
    /// <summary>
    /// Storage module manager
    /// </summary>
    public partial class StorageModuleManager : ModuleManager
    {
        protected IDatabaseAccess dbAccess;

        /// <summary>
        /// Init storage module manager
        /// </summary>
        /// <param name="dbAccessType"></param>
        /// <param name="connectionString"></param>
        /// <param name="useCache"></param>
        public StorageModuleManager(Type dbAccessType, string connectionString = "", bool useCache = false) : base()
        {
            if (string.IsNullOrEmpty(connectionString))
                connectionString = ApplicationData.Current.LocalFolder.Path;

            CreateDbAccess(dbAccessType, connectionString, useCache);
        }

        /// <summary>
        /// Create database
        /// </summary>
        /// <param name="dbAccessType">Database access type</param>
        /// <param name="connectionString">Connection string for database</param>
        /// <param name="useCache">Write records into memory</param>
        private void CreateDbAccess(Type dbAccessType, string connectionString, bool useCache)
        {
            dbAccess = (IDatabaseAccess)Activator.CreateInstance(dbAccessType, connectionString, useCache);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="module"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override bool RegisterModule(Module module)
        {
            var storageModule = (StorageModule)module;
            storageModule.SetDbAccess(dbAccess);

            return base.RegisterModule(module);
        }

        /// <summary>
        /// Create database
        /// </summary>
        public void CreateDatabase()
        {
            dbAccess.CreateDatabase();
        }

        /// <summary>
        /// Update database
        /// </summary>
        public void UpdateDatabase()
        {
            dbAccess.UpdateDatabase();
        }

        /// <summary>
        /// Remove database
        /// </summary>
        public void RemoveDatabase()
        {
            dbAccess.RemoveDatabase();
        }
    }
}