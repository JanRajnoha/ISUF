using ISUF.Base.Service;
using ISUF.Base.Template;
using ISUF.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.DatabaseAccess
{
    public class SqlDbAccess : DatabaseAccess
    {
        public SqlDbAccess(string connectionString) : base(connectionString)
        {
        }

        public override bool CheckConnectionString(string connectionString)
        {
            try
            {
                SqlConnection testConnection = new SqlConnection(connectionString);
                testConnection.Open();
                if (testConnection.State == System.Data.ConnectionState.Broken)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                LogService.AddLogMessage(ex.Message);
                return false;
            }
        }

        public override void CreateDatabase()
        {
        }

        public override void UpdateDatabase()
        {
        }

        public override void RemoveDatabase()
        {
        }

        public override Task<bool> AddItemIntoDatabase<T>(T newItem)
        {
            throw new NotImplementedException();
        }

        public override void CreateDatabaseTable(string tableName, Type tableType)
        {
            throw new NotImplementedException();
        }

        public override ObservableCollection<T> GetAllItems<T>()
        {
            throw new NotImplementedException();
        }

        public override T GetItem<T>(int ID)
        {
            throw new NotImplementedException();
        }

        public override bool IsItemInDatabase<T>(int ID)
        {
            throw new NotImplementedException();
        }

        public override void RemoveAllRows()
        {
            throw new NotImplementedException();
        }

        public override void RemoveDatabaseTable(string tableName)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> RemoveRow<T>(int ID)
        {
            throw new NotImplementedException();
        }

        public override Task SetSourceCollection<T>(ObservableCollection<T> source)
        {
            throw new NotImplementedException();
        }

        public override void UpdateDatabaseTable(string tableName, Type tableType)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateItem<T>(T updateItem)
        {
            throw new NotImplementedException();
        }

        //protected override ObservableCollection<T> GetFinalCollection<T>()
        //{
        //    throw new NotImplementedException();
        //}

        public override Task WriteInMemoryCache<T>()
        {
            throw new NotImplementedException();
        }

        public override Task ClearChangesInMemoryCache<T>()
        {
            throw new NotImplementedException();
        }

        public override Task<ObservableCollection<T>> ReloadInMemoryCache<T>(bool writeChangesIntoFB)
        {
            throw new NotImplementedException();
        }
    }
}
