using ISUF.Base.Modules;
using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Interface.Storage
{
    /// <summary>
    /// Basic item manager interface
    /// </summary>
    public interface IAtomicItemManager
    {
        /// <summary>
        /// Add item
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="item">Item values</param>
        /// <param name="moduleManager">Module manager for item</param>
        /// <param name="ignoreLinkedTableUpdate">Ignore updates for linked tables</param>
        /// <returns>Success of task</returns>
        bool AddItem<T>(T item, ModuleManager moduleManager, bool ignoreLinkedTableUpdate = false) where T : AtomicItem;

        /// <summary>
        /// Addition checks for addition
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="item">Item values</param>
        /// <returns>Success of addition</returns>
        bool AddItemAdditionCheck<T>(T item) where T : AtomicItem;

        /// <summary>
        /// Add item range
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="item">Item values</param>
        /// <param name="moduleManager">Module manager for item</param>
        /// <param name="checkItems">During addition, check items</param>
        /// <returns>Successes of tasks</returns>
        Task<bool> AddItemRange<T>(List<T> item, ModuleManager moduleManager, bool checkItems = true) where T : AtomicItem;

        /// <summary>
        /// Get all items
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <returns>List of all items</returns>
        List<T> GetAllItems<T>() where T : AtomicItem;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="detailedItem"></param>
        /// <param name="moduleManager"></param>
        /// <returns></returns>
        Task<bool> RemoveItem<T>(T detailedItem, ModuleManager moduleManager) where T : AtomicItem;

        /// <summary>
        /// Remove item on selected index
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="id">Item index</param>
        /// <param name="moduleManager">Module manager for item</param>
        /// <returns>Sucscess of task</returns>
        Task<bool> RemoveItem<T>(int id, ModuleManager moduleManager) where T : AtomicItem;

        /// <summary>
        /// Get item by index
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="ID">Item index</param>
        /// <returns>Item by index</returns>
        T GetItem<T>(int ID) where T : AtomicItem;

        /// <summary>
        /// Update table in database
        /// </summary>
        void UpdateDatabaseTable();

        /// <summary>
        /// Create table in database
        /// </summary>
        void CreateDatabaseTable();

        /// <summary>
        /// Remove table in database
        /// </summary>
        void RemoveDatabaseTable();
    }
}
