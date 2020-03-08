using ISUF.Base.Modules;
using ISUF.Base.Template;
using ISUF.Interface.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ISUF.Storage.Modules
{
    public class StorageModule : Module, IStorageModuleItemAccess
    {
        public string ModuleTableName { get; private set; }

        protected Type itemManagerType;
        protected IDatabaseAccess dbAccess;
        protected IAtomicItemManager itemManager;

        public StorageModule(Type moduleItemType, Type itemManagerType, string moduleTableName = null) : base(moduleItemType)
        {
            SetModuleInfo(itemManagerType, moduleTableName);
        }

        public StorageModule(Type moduleItemType, string moduleName, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, moduleName)
        {
            SetModuleInfo(itemManagerType, moduleTableName);
        }

        private void SetModuleInfo(Type itemManagerType, string moduleTableName)
        {
            this.itemManagerType = itemManagerType;
            this.ModuleTableName = moduleTableName ?? ModuleName;
        }

        private void CreateItemManager() => itemManager = (IAtomicItemManager)Activator.CreateInstance(itemManagerType, dbAccess, ModuleItemType, ModuleName);

        public void SetDbAccess(IDatabaseAccess dbAccess)
        {
            this.dbAccess = dbAccess;
            CreateItemManager();
        }

        public T GetItemById<T>(int id) where T : AtomicItem
        {
            return itemManager.GetItem<T>(id);
        }

        public bool AddItem<T>(T newItem, bool ignoreLinkedTableUpdate = false) where T : AtomicItem
        {
            return itemManager.AddItem(newItem, moduleManager, ignoreLinkedTableUpdate);
        }

        public bool RemoveItemById<T>(int id) where T : AtomicItem
        {
            return RemoveItemByIdAsync<T>(id).Result;
        }

        public Task<bool> RemoveItemByIdAsync<T>(int id) where T : AtomicItem
        {
            return itemManager.RemoveItem<T>(id, moduleManager);
        }

        public List<T> GetAllItems<T>() where T : AtomicItem
        {
            return itemManager.GetAllItems<T>();
        }

        public bool EditItem<T>(T editedItem) where T : AtomicItem
        {
            return itemManager.AddItem(editedItem, moduleManager);
        }

        public virtual void UpdateDatabaseTable()
        {
            itemManager.UpdateDatabaseTable();
        }

        public virtual void CreateDatabaseTable()
        {
            itemManager.CreateDatabaseTable();
        }

        public virtual void RemoveDatabaseTable()
        {
            itemManager.RemoveDatabaseTable();
        }
    }
}
