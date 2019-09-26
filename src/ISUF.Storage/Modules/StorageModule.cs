using ISUF.Base.Modules;
using ISUF.Base.Template;
using ISUF.Interface.Storage;
using System;
using System.Collections.ObjectModel;

namespace ISUF.Storage.Modules
{
    public class StorageModule : Module, IStorageModuleItemAccess
    {
        protected Type itemManagerType;

        protected IAtomicItemManager itemManager { get; set; }

        protected IDatabaseAccess dbAccess;
        protected string moduleTableName;

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
            this.moduleTableName = moduleTableName ?? moduleName;
        }

        private void CreateItemManager() => itemManager = (IAtomicItemManager)Activator.CreateInstance(itemManagerType, dbAccess, moduleItemType, moduleName);

        public void SetDbAccess(IDatabaseAccess dbAccess)
        {
            this.dbAccess = dbAccess;
            CreateItemManager();
        }

        public T GetItemById<T>(int id) where T : AtomicItem
        {
            return itemManager.GetItem<T>(id);
        }

        public bool AddItem<T>(T newItem) where T : AtomicItem
        {
            return itemManager.AddItem(newItem);
        }

        public bool RemoveItemById(int id)
        {
            return itemManager.RemoveItem<AtomicItem>(id).Result;
        }

        public ObservableCollection<T> GetAllItems<T>() where T : AtomicItem
        {
            return itemManager.GetAllItems<T>().Result;
        }

        public bool EditItem<T>(T editedItem) where T : AtomicItem
        {
            return itemManager.AddItem(editedItem);
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
