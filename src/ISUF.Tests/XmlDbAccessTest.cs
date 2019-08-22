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
            storageTestModule = new StorageModule(typeof(TestClass2), typeof(ItemManager));

            storageTestManager.RegisterModule(storageTestModule);
        }

        [TestMethod]
        public void CreateDatabase()
        {
            storageTestManager.CreateDatabase();

            Assert.IsTrue(File.Exists($@"C:\Users\JR\Documents\Test\{typeof(TestClass).Name}"));
            Assert.IsTrue(File.Exists($@"C:\Users\JR\Documents\Test\{typeof(TestClass2).Name}"));
        }

        [TestMethod]
        public void UpdateDatabase()
        {
            storageTestManager.UpdateDatabase();

            Assert.IsTrue(File.Exists($@"C:\Users\JR\Documents\Test\{typeof(TestClass).Name}"));
            Assert.IsTrue(File.Exists($@"C:\Users\JR\Documents\Test\{typeof(TestClass2).Name}"));
        }

        [TestMethod]
        public void RemoveDatabase()
        {
            storageTestManager.RemoveDatabase();

            Assert.IsTrue(!File.Exists($@"C:\Users\JR\Documents\Test\{typeof(TestClass).Name}"));
            Assert.IsTrue(!File.Exists($@"C:\Users\JR\Documents\Test\{typeof(TestClass2).Name}"));
        }

        [TestMethod]
        public void CreateTable()
        {
            StorageModule module = (StorageModule)storageTestManager.GetModule(typeof(TestClass));
            module.ItemManager.CreateDatabaseTable();

            Assert.IsTrue(File.Exists($@"C:\Users\JR\Documents\Test\{typeof(TestClass).Name}"));
        }

        [TestMethod]
        public void UpdateTable()
        {
            StorageModule module = (StorageModule)storageTestManager.GetModule(typeof(TestClass));
            module.ItemManager.UpdateDatabaseTable();

            Assert.IsTrue(File.Exists($@"C:\Users\JR\Documents\Test\{typeof(TestClass).Name}"));
        }

        [TestMethod]
        public void RemoveTable()
        {
            StorageModule module = (StorageModule)storageTestManager.GetModule(typeof(TestClass));
            module.ItemManager.RemoveDatabaseTable();

            Assert.IsTrue(!File.Exists($@"C:\Users\JR\Documents\Test\{typeof(TestClass).Name}"));
        }

        [TestMethod]
        public void AddItemIntoDatabase()
        {
            StorageModule module = (StorageModule)storageTestManager.GetModule(typeof(TestClass));
            TestClass testItem = new TestClass();
            testItem.IntProp = 5;
            testItem.StringProp = "asd";

            module.ItemManager.AddItem(testItem);

            var item = module.ItemManager.GetItem<TestClass>(0);

            Assert.AreEqual("asd", item.StringProp);
        }

        [TestMethod]
        public void UpdateItemInDatabase()
        {
            StorageModule module = (StorageModule)storageTestManager.GetModule(typeof(TestClass));
            TestClass testItem = new TestClass();
            testItem.IntProp = 5;
            testItem.StringProp = "asd";

            module.ItemManager.AddItem(testItem);

            var item = module.ItemManager.GetItem<TestClass>(0);

            Assert.AreEqual("asd", item.StringProp);

            item.IntProp = 999;
            module.ItemManager.AddItem(item);

            var editedItem = module.ItemManager.GetItem<TestClass>(0);

            Assert.AreEqual(999, editedItem.IntProp);
        }

        [TestMethod]
        public void RemoveItemFromDatabase()
        {
            StorageModule module = (StorageModule)storageTestManager.GetModule(typeof(TestClass));
            TestClass testItem = new TestClass();
            testItem.IntProp = 5;
            testItem.StringProp = "asd";

            module.ItemManager.AddItem(testItem);

            var item = module.ItemManager.GetItem<TestClass>(0);

            Assert.AreEqual("asd", item.StringProp);

            module.ItemManager.RemoveItem(item);

            var removedItem = module.ItemManager.GetItem<TestClass>(0);

            Assert.AreEqual(null, removedItem);
        }
    }
}
