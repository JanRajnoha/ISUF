using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISUF.Base.Template;
using ISUF.Storage.DatabaseAccess;
using ISUF.Storage.Manager;
using ISUF.Storage.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISUF.Tests
{
    [TestClass]
    public class XmlDbAccessTest : IDbAccessTest
    {
        public StorageModuleManager storageTestManager { get; set; }
        public StorageModule storageTestModule { get; set; }
        public TestClass testItem { get; set; }

        [TestInitialize]
        public void PrepareData()
        {
            storageTestManager = new StorageModuleManager(typeof(XmlDbAccess), @"C:\Users\JR\Documents\Test", false);
            storageTestModule = new StorageModule(typeof(TestClass), typeof(ItemManager));

            storageTestManager.RegisterModule(storageTestModule);
        }

        [TestMethod]
        public void CreateDatabase()
        {
            storageTestManager.CreateDatabase();

            Assert.IsTrue(File.Exists($@"C:\Users\JR\Documents\Test\{typeof(TestClass).Name}"));
        }

        [TestMethod]
        public void RemoveDatabase()
        {
            storageTestManager.RemoveDatabase();

            Assert.IsTrue(!File.Exists($@"C:\Users\JR\Documents\Test\{typeof(TestClass).Name}"));
        }

        [TestMethod]
        public void UpdateDatabase()
        {
            storageTestManager.UpdateDatabase();

            Assert.IsTrue(File.Exists($@"C:\Users\JR\Documents\Test\{typeof(TestClass).Name}"));
        }

        [TestMethod]
        public void CreateTable()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void RemoveTable()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void UpdateTable()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void AddItemIntoDatabase()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void UpdateItemInDatabase()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void RemoveItemFromDatabase()
        {
            Assert.IsTrue(false);
        }
    }
}
