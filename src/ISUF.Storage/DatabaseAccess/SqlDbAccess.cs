using ISUF.Base.Service;
using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ISUF.Storage.DatabaseAccess
{
    /// <summary>
    /// SQL Database access
    /// </summary>
    public class SqlDbAccess : DatabaseAccess
    {
        /// <summary>
        /// Initial of SQL database access
        /// </summary>
        /// <param name="connectionString">Connection string for database</param>
        public SqlDbAccess(string connectionString) : base(connectionString)
        {
        }

        /// <inheritdoc/>
        public override bool CheckConnectionString(string connectionString)
        {
            try
            {
                SqlConnection testConnection = new SqlConnection(connectionString);
                testConnection.Open();
                return testConnection.State != System.Data.ConnectionState.Broken;
            }
            catch (Exception ex)
            {
                LogService.AddLogMessage(ex.Message);
                return false;
            }
        }

        /// <inheritdoc/>
        public override void CreateDatabase()
        {
        }

        /// <inheritdoc/>
        public override void UpdateDatabase()
        {
        }

        /// <inheritdoc/>
        public override void RemoveDatabase()
        {
        }

        /// <inheritdoc/>
        public override Task<bool> AddItemIntoDatabase<T>(T newItem)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override void CreateDatabaseTable(Type tableType)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override List<T> GetAllItems<T>()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override T GetItem<T>(int ID)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override bool IsItemInDatabase<T>(int ID)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override void RemoveAllItemsFromDatabase()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override void RemoveDatabaseTable(Type tableType)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override Task<bool> RemoveItemFromDatabase<T>(int ID)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override Task SetSourceCollection<T>(List<T> source)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override void UpdateDatabaseTable(Type tableType)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override Task<bool> EditItemInDatabase<T>(T editedItem)
        {
            throw new NotImplementedException();
        }

        //protected override ObservableCollection<T> GetFinalCollection<T>()
        //{
        //    throw new NotImplementedException();
        //}

        /// <inheritdoc/>
        public override Task WriteInMemoryCache<T>()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override Task ClearChangesInMemoryCache<T>()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override Task<List<T>> ReloadInMemoryCache<T>(bool writeChangesIntoFB)
        {
            throw new NotImplementedException();
        }

        //public override void WriteHistory()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
