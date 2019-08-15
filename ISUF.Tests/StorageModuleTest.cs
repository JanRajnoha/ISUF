using ISUF.Storage.DatabaseAccess;
using ISUF.Storage.Manager;
using ISUF.Storage.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ISUF.Tests
{
    [TestClass]
    public class StorageModuleTest
    {
        StorageModuleManager storageModuleEnum;
        StorageModule storageMod;

        [TestMethod]
        public void RelativePathXmlDbAccessTest()
        {
            StorageModuleManager storageModuleManager;

            try
            {
                storageModuleManager = new StorageModuleManager(typeof(XmlDbAccess));

                storageModuleManager.DbAccess = new XmlDbAccess("", false);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            Assert.IsTrue(true);
        }

        [TestMethod]
        [Priority(3)]   
        public void AbsolutePathXmlDbAccessTest()
        {
            try
            {
                storageModuleEnum = new StorageModuleManager(typeof(XmlDbAccess));

                storageModuleEnum.DbAccess = new XmlDbAccess(@"C:\Users\JR\Documents\Test", false);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            Assert.IsTrue(true);
        }

        [TestMethod]
        [Priority(5)]
        public void CreateStorugeModuleTest()
        {
            AbsolutePathXmlDbAccessTest();

            Assert.IsNull(storageMod);

            storageMod = new StorageModule(typeof(TestClass), typeof(ItemManager));

            Assert.IsNotNull(storageMod);
        }

        [TestMethod]
        [Priority(4)]
        public void AddStorugeModuleTest()
        {
            AbsolutePathXmlDbAccessTest();

            CreateStorugeModuleTest();

            Assert.IsTrue(storageModuleEnum.ModuleCount() == 0);

            storageModuleEnum.RegisterModule(storageMod);

            Assert.IsTrue(storageModuleEnum.ModuleCount() != 0);
        }
    }
}
