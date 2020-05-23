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

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        private void CreateItemManager() => itemManager = (IAtomicItemManager)Activator.CreateInstance(itemManagerType, dbAccess, ModuleItemType, ModuleName);

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="dbAccess"><inheritdoc/></param>
        public void SetDbAccess(IDatabaseAccess dbAccess)
        {
            this.dbAccess = dbAccess;
            CreateItemManager();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="id"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public T GetItemById<T>(int id) where T : AtomicItem
        {
            return itemManager.GetItem<T>(id);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="newItem"><inheritdoc/></param>
        /// <param name="ignoreLinkedTableUpdate"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public bool AddItem<T>(T newItem, bool ignoreLinkedTableUpdate = false) where T : AtomicItem
        {
            return itemManager.AddItem(newItem, moduleManager, ignoreLinkedTableUpdate);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="id"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public bool RemoveItemById<T>(int id) where T : AtomicItem
        {
            return RemoveItemByIdAsync<T>(id).Result;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="id"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public Task<bool> RemoveItemByIdAsync<T>(int id) where T : AtomicItem
        {
            return itemManager.RemoveItem<T>(id, moduleManager);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <returns><inheritdoc/></returns>
        public List<T> GetAllItems<T>() where T : AtomicItem
        {
            return itemManager.GetAllItems<T>();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <param name="editedItem"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public bool EditItem<T>(T editedItem) where T : AtomicItem
        {
            return itemManager.AddItem(editedItem, moduleManager);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public virtual void UpdateDatabaseTable()
        {
            itemManager.UpdateDatabaseTable();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public virtual void CreateDatabaseTable()
        {
            itemManager.CreateDatabaseTable();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public virtual void RemoveDatabaseTable()
        {
            itemManager.RemoveDatabaseTable();
        }
    }
}
