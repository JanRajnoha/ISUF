using ISUF.Base.Template;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ISUF.Interface.Storage
{
    /// <summary>
    /// Storage module item access interface
    /// </summary>
    public interface IStorageModuleItemAccess
    {
        /// <summary>
        /// Get item by id for item type
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="id">Item index</param>
        /// <returns>Item by index</returns>
        T GetItemById<T>(int id) where T : AtomicItem;

        /// <summary>
        /// Add item for item type
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="newItem">New item values</param>
        /// <param name="ignoreLinkedTableUpdate">Ignore updates for linked tables</param>
        /// <returns>Success of task</returns>
        bool AddItem<T>(T newItem, bool ignoreLinkedTableUpdate = false) where T : AtomicItem;

        /// <summary>
        /// Remove item by id for item type
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="id">Item index</param>
        /// <returns>Success of task</returns>
        bool RemoveItemById<T>(int id) where T : AtomicItem;

        /// <summary>
        /// Get all items fot item type
        /// </summary>
        /// <typeparam name="T">Itme type</typeparam>
        /// <returns>All items</returns>
        List<T> GetAllItems<T>() where T : AtomicItem;

        /// <summary>
        /// Edit item for item type
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="editedItem">Edited item</param>
        /// <returns>Success of task</returns>
        bool EditItem<T>(T editedItem) where T : AtomicItem;
    }
}
