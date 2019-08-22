using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Tests
{
    public interface IDbAccessTest
    {
        void PrepareData();
        void CreateDatabase();
        void RemoveDatabase();
        void UpdateDatabase();
        void CreateTable();
        void RemoveTable();
        void UpdateTable();
        void AddItemIntoDatabase();
        void UpdateItemInDatabase();
        void RemoveItemFromDatabase();
    }
}
