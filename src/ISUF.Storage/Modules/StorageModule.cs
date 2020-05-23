using ISUF.Base.Modules;
using ISUF.Base.Template;
using ISUF.Interface.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ISUF.Storage.Modules
{
    /// <summary>
    /// Storage module
    /// </summary>
    public class StorageModule : Module, IStorageModuleItemAccess
    {
        public string ModuleTableName { get; private set; }

        protected Type itemManagerType;
        protected IDatabaseAccess dbAccess;
        protected IAtomicItemManager itemManager;

        /// <summary>
        /// Init storage module
        /// </summary>
        /// <param name="moduleItemType">Item type</param>
        /// <param name="itemManagerType">Manager type</param>
        /// <param name="moduleTableName">Module table name</param>
        public StorageModule(Type moduleItemType, Type itemManagerType, string moduleTableName = null) : base(moduleItemType)
        {
            SetModuleInfo(itemManagerType, moduleTableName);
        }

        /// <summary>
        /// Init storage module
        /// </summary>
        /// <param name="moduleItemType">Item type</param>
        /// <param name="moduleName">Module name</param>
        /// <param name="itemManagerType">Manager type</param>
        /// <param name="moduleTableName">Module table name</param>
        public StorageModule(Type moduleItemType, string moduleName, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, moduleName)
        {
            SetModuleInfo(itemManagerType, moduleTableName);
        }

        /// <summary>
        /// Set information about module
        /// </summary>
        /// <param name="itemManagerType">Manager type</param>
        /// <param name="moduleTableName">Module table name</param>
        private void SetModuleInfo(Type itemManagerType, string moduleTableName)
        {
            this.itemManagerType = itemManagerType;
            this.ModuleTableName = moduleTableName ?? ModuleName;
        }

        /// <inheritdoc/>
        private void CreateItemManager() => itemManager = (IAtomicItemManager)Activator.CreateInstance(itemManagerType, dbAccess, ModuleItemType, ModuleName);

        /// <inheritdoc/>
        public void SetDbAccess(IDatabaseAccess dbAccess)
        {
            this.dbAccess = dbAccess;
            CreateItemManager();
        }

        /// <inheritdoc/>
        public T GetItemById<T>(int id) where T : AtomicItem
        {
            return itemManager.GetItem<T>(id);
        }

        /// <inheritdoc/>
        public bool AddItem<T>(T newItem, bool ignoreLinkedTableUpdate = false) where T : AtomicItem
        {
            return itemManager.AddItem(newItem, moduleManager, ignoreLinkedTableUpdate);
        }

        /// <inheritdoc/>
        public bool RemoveItemById<T>(int id) where T : AtomicItem
        {
            return RemoveItemByIdAsync<T>(id).Result;
        }

        /// <inheritdoc/>
        public Task<bool> RemoveItemByIdAsync<T>(int id) where T : AtomicItem
        {
            return itemManager.RemoveItem<T>(id, moduleManager);
        }

        /// <inheritdoc/>
        public List<T> GetAllItems<T>() where T : AtomicItem
        {
            return itemManager.GetAllItems<T>();
        }

        /// <inheritdoc/>
        public bool EditItem<T>(T editedItem) where T : AtomicItem
        {
            return itemManager.AddItem(editedItem, moduleManager);
        }

        /// <inheritdoc/>
        public virtual void UpdateDatabaseTable()
        {
            itemManager.UpdateDatabaseTable();
        }

        /// <inheritdoc/>
        public virtual void CreateDatabaseTable()
        {
            itemManager.CreateDatabaseTable();
        }

        /// <inheritdoc/>
        public virtual void RemoveDatabaseTable()
        {
            itemManager.RemoveDatabaseTable();
        }
    }
}
