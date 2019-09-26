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
using Windows.Storage;

namespace ISUF.Tests
{
    [TestClass]
    public class XmlDbAccessTest : IDbAccessTest
    {
        StorageModuleManager storageTestManager;
        StorageModule storageTestModule;
        StorageModule storageTestModule2;

        [TestInitialize]
        public void PrepareData()
        {
            storageTestManager = new StorageModuleManager(typeof(XmlDbAccess), ApplicationData.Current.LocalFolder.Path ,false);
            storageTestModule = new StorageModule(typeof(TestClass), typeof(AtomicItemManager));
            storageTestModule2 = new StorageModule(typeof(TestClass2), typeof(AtomicItemManager));

            storageTestManager.RegisterModule(storageTestModule);
            storageTestManager.RegisterModule(storageTestModule2);
        }

        [TestMethod]
        public void CreateDatabase()
        {
            storageTestManager.CreateDatabase();

            Assert.IsTrue(File.Exists($@"{ApplicationData.Current.LocalFolder.Path}\{typeof(TestClass).Name}.xml"));
            Assert.IsTrue(File.Exists($@"{ApplicationData.Current.LocalFolder.Path}\{typeof(TestClass2).Name}.xml"));
        }

        [TestMethod]
        public void UpdateDatabase()
        {
            storageTestManager.UpdateDatabase();

            Assert.IsTrue(File.Exists($@"{ApplicationData.Current.LocalFolder.Path}\{typeof(TestClass).Name}.xml"));
            Assert.IsTrue(File.Exists($@"{ApplicationData.Current.LocalFolder.Path}\{typeof(TestClass2).Name}.xml"));
        }

        [TestMethod]
        public void RemoveDatabase()
        {
            storageTestManager.RemoveDatabase();

            Assert.IsTrue(!File.Exists($@"{ApplicationData.Current.LocalFolder.Path}\{typeof(TestClass).Name}.xml"));
            Assert.IsTrue(!File.Exists($@"{ApplicationData.Current.LocalFolder.Path}\{typeof(TestClass2).Name}.xml"));
        }

        [TestMethod]
        public void CreateTable()
        {
            StorageModule module = (StorageModule)storageTestManager.GetModule(typeof(TestClass));
            module.CreateDatabaseTable();

            Assert.IsTrue(File.Exists($@"{ApplicationData.Current.LocalFolder.Path}\{typeof(TestClass).Name}.xml"));
        }

        [TestMethod]
        public void UpdateTable()
        {
            StorageModule module = (StorageModule)storageTestManager.GetModule(typeof(TestClass));
            module.UpdateDatabaseTable();

            Assert.IsTrue(File.Exists($@"{ApplicationData.Current.LocalFolder.Path}\{typeof(TestClass).Name}.xml"));
        }

        [TestMethod]
        public void RemoveTable()
        {
            StorageModule module = (StorageModule)storageTestManager.GetModule(typeof(TestClass));
            module.RemoveDatabaseTable();

            Assert.IsTrue(!File.Exists($@"{ApplicationData.Current.LocalFolder.Path}\{typeof(TestClass).Name}.xml"));
        }

        [TestMethod]
        public void AddItemIntoDatabase()
        {
            StorageModule module = (StorageModule)storageTestManager.GetModule(typeof(TestClass));
            module.UpdateDatabaseTable();
            TestClass testItem = new TestClass
            {
                IntProp = 5,
                StringProp = "asd"
            };

            module.AddItem(testItem);

            var item = module.GetItemById<TestClass>(1);

            Assert.AreEqual("asd", item.StringProp);
        }

        [TestMethod]
        public void UpdateItemInDatabase()
        {
            StorageModule module = (StorageModule)storageTestManager.GetModule(typeof(TestClass));
            module.UpdateDatabaseTable();
            TestClass testItem = new TestClass
            {
                IntProp = 5,
                StringProp = "asd"
            };

            module.AddItem(testItem);

            var item = module.GetItemById<TestClass>(1);

            Assert.AreEqual("asd", item.StringProp);

            item.IntProp = 999;
            module.AddItem(item);

            var editedItem = module.GetItemById<TestClass>(1);

            Assert.AreEqual(999, editedItem.IntProp);
        }

        [TestMethod]
        public void RemoveItemFromDatabase()
        {
            StorageModule module = (StorageModule)storageTestManager.GetModule(typeof(TestClass));
            module.UpdateDatabaseTable();
            TestClass testItem = new TestClass
            {
                IntProp = 5,
                StringProp = "asd"
            };

            module.AddItem(testItem);

            var item = module.GetItemById<TestClass>(1);

            Assert.AreEqual("asd", item.StringProp);

            module.RemoveItemById(item.Id);

            var removedItem = module.GetItemById<TestClass>(1);

            Assert.AreEqual(null, removedItem);
        }
    }
}
