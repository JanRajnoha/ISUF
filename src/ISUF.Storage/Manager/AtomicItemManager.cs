using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ISUF.Base.Template;
using ISUF.Base.Settings;
using ISUF.Security;
using ISUF.Base.Service;
using System;
using ISUF.Interface.Storage;
using ISUF.Base.Modules;
using ISUF.Base.Attributes;
using ISUF.Storage.Modules;
using System.Reflection;

namespace ISUF.Storage.Manager
{
    /// <summary>
    /// Atomic item manager class
    /// </summary>
    public class AtomicItemManager : IAtomicItemManager
    {
        protected string moduleName;
        protected Type moduleItemType;
        protected IDatabaseAccess dbAccess;
        protected object itemsSource;
        protected bool dbMemoryDirty = true;
        protected object oldItem;

        /// <summary>
        /// Create instance of class for selected file and register UserLogChanged
        /// </summary>
        /// <param name="dbAccess">Database Access object for working with database</param>
        /// <param name="moduleItemType"></param>
        /// <param name="moduleName"></param>
        public AtomicItemManager(IDatabaseAccess dbAccess, Type moduleItemType, string moduleName)
        {
            this.dbAccess = dbAccess;
            this.moduleName = moduleName;
            this.moduleItemType = moduleItemType;

            dbAccess.RegisterModule(moduleItemType, moduleName);

            CustomSettings.UserLogChanged += CustomSettings_UserLogChanged;
        }

        /// <summary>
        /// Function for change security event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void CustomSettings_UserLogChanged(object sender, UserLoggedEventArgs e)
        {
            LogService.AddLogMessage($"User secure settings has changed. Log called from {GetType()}.");
        }

        /// <inheritdoc/>
        public virtual bool AddItem<T>(T item, ModuleManager moduleManager, bool ignoreLinkedTableUpdate = false) where T : AtomicItem
        {
            T newItem = item;

            newItem.Encrypted = false;

            var itemSource = GetAllItems<T>();
            dbMemoryDirty = true;

            if (!AddItemAdditionCheck(item))
                return false;

            if (newItem.Id == -1)
            {
                newItem.Id = itemSource != null ? GetID(itemSource) : 0;

                if (ignoreLinkedTableUpdate == false)
                    UpdateLinkedTableValues(item, moduleManager);

                return dbAccess.AddItemIntoDatabase(newItem).Result;
            }
            else
            {
                oldItem = GetItem<T>(newItem.Id);
                dbMemoryDirty = true;

                if (ignoreLinkedTableUpdate == false)
                    UpdateLinkedTableValues(item, moduleManager);

                return dbAccess.EditItemInDatabase(newItem).Result;
            }
        }

        /// <inheritdoc/>
        public virtual bool AddItemAdditionCheck<T>(T item) where T : AtomicItem
        {
            return true;
        }

        /// <inheritdoc/>
        public virtual async Task<bool> AddItemRange<T>(List<T> itemList, ModuleManager moduleManager, bool checkItems = true) where T : AtomicItem
        {
            bool res = true;
            dbMemoryDirty = true;

            foreach (var item in itemList)
            {
                if (checkItems)
                    res &= AddItem(item, moduleManager);
                else
                    res &= await dbAccess.AddItemIntoDatabase(item);

                if (res == false)
                    break;
            }

            return res;
        }

        /// <inheritdoc/>
        public virtual async Task<bool> RemoveItem<T>(T detailedItem, ModuleManager moduleManager) where T : AtomicItem
        {
            //UpdatePhraseList();

            return await RemoveItem<T>(detailedItem.Id, moduleManager);
        }

        /// <inheritdoc/>
        public virtual async Task<bool> RemoveItem<T>(int id, ModuleManager moduleManager) where T : AtomicItem
        {
            //UpdatePhraseList();

            var item = SetLinkedTablesValuesToDefault(GetItem<T>(id), moduleManager);
            UpdateLinkedTableValues(item, moduleManager);
            AddItem(item, moduleManager);

            dbMemoryDirty = true;

            return await dbAccess.RemoveItemFromDatabase<T>(id);
        }

        /// <summary>
        /// Clear values in linked tables
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="item">Selected item</param>
        /// <param name="moduleManager">Module manager</param>
        /// <returns>Updated item</returns>
        protected T SetLinkedTablesValuesToDefault<T>(T item, ModuleManager moduleManager) where T : AtomicItem
        {
            var currentModule = moduleManager.GetModuleByItemType(typeof(T));
            var propsAnalyze = moduleManager.ModuleAnalyser.AnalyseAndGet(currentModule.ModuleItemType);
            var linkedTableInfoPropsAnalyze = propsAnalyze.Where(x => x.Value.PropertyAttributes.FirstOrDefault(y => y.GetType() == typeof(LinkedTableAttribute)) != null).Select(x => x.Value).ToList();

            foreach (var propAnalyze in linkedTableInfoPropsAnalyze)
            {
                var linkedTableInfo = propAnalyze.PropertyAttributes.First(x => x.GetType() == typeof(LinkedTableAttribute)) as LinkedTableAttribute;

                switch (linkedTableInfo.LinkedTableRelation)
                {
                    case Base.Enum.LinkedTableRelation.One:

                        typeof(T).GetProperty(propAnalyze.PropertyName).SetValue(item, -1);
                        break;

                    case Base.Enum.LinkedTableRelation.Many:

                        typeof(T).GetProperty(propAnalyze.PropertyName).SetValue(item, new List<int>());
                        break;

                    default:
                        throw new Base.Exceptions.NotSupportedException("Unsupported relations between tables.");
                }
            }

            return item;
        }

        /// <summary>
        /// Get ID for item. If any ID missing, return value of this ID.
        /// If not, return next ID from row.
        /// </summary>
        /// <returns>New ID</returns>
        protected virtual int GetID<T>(List<T> itemSource) where T : AtomicItem
        {
            int index = 0;

            var orderedItemSource = itemSource.OrderBy(x => x.Id).ToList();

            for (int i = 0; i < orderedItemSource.Count; i++)
            {
                if (orderedItemSource[i].Id != index)
                    return index;
                else
                    index++;
            }

            return itemSource.Count + 1;
        }
        
        /// <inheritdoc/>
        public virtual T GetItem<T>(int ID) where T : AtomicItem
        {
            if (dbMemoryDirty)
                itemsSource = GetAllItems<T>();

            return (itemsSource as IReadOnlyList<T>).FirstOrDefault(x => x.Id == ID);
        }

        /// <inheritdoc/>
        public virtual void UpdateDatabaseTable()
        {
            dbAccess.UpdateDatabaseTable(moduleItemType);
        }

        /// <inheritdoc/>
        public virtual void CreateDatabaseTable()
        {
            dbAccess.CreateDatabaseTable(moduleItemType);
        }

        /// <inheritdoc/>
        public virtual void RemoveDatabaseTable()
        {
            dbAccess.RemoveDatabaseTable(moduleItemType);
        }

        /// <inheritdoc/>
        public virtual List<T> GetAllItems<T>() where T : AtomicItem
        {
            if (dbMemoryDirty)
            {
                itemsSource = dbAccess.GetAllItems<T>();
                dbMemoryDirty = false;
            }

            return itemsSource as List<T> ?? new List<T>();
        }

        /// <summary>
        /// Get all items by async
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <returns>Collection of items</returns>
        public virtual async Task<List<T>> GetItemsAsync<T>() where T : AtomicItem
        {
            var itemSource = dbAccess.GetAllItems<T>();

            foreach (var item in itemSource)
            {
                if (item.Secured && item.Encrypted)
                    item.Encrypted = false;
            }

            return itemSource;
        }

        /// <summary>
        /// Update values in linked tables
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="item">Selected item</param>
        /// <param name="moduleManager">Module manager</param>
        protected void UpdateLinkedTableValues<T>(T item, ModuleManager moduleManager) where T : AtomicItem
        {
            var currentModule = moduleManager.GetModuleByItemType(typeof(T));
            var propsAnalyze = moduleManager.ModuleAnalyser.AnalyseAndGet(currentModule.ModuleItemType);
            var linkedTableInfoPropsAnalyze = propsAnalyze.Where(x => x.Value.PropertyAttributes.FirstOrDefault(y => y.GetType() == typeof(LinkedTableAttribute)) != null).Select(x => x.Value).ToList();

            foreach (var propAnalyze in linkedTableInfoPropsAnalyze)
            {
                var linkedTableInfo = propAnalyze.PropertyAttributes.First(x => x.GetType() == typeof(LinkedTableAttribute)) as LinkedTableAttribute;

                if (!(moduleManager.GetModule(linkedTableInfo.LinkedTableType) is StorageModule linkedModule))
                    throw new Base.Exceptions.NotSupportedException("Linked table must have base class StorageModule");

                var linkedPropsAnalyze = moduleManager.ModuleAnalyser.AnalyseAndGet(linkedModule.ModuleItemType);
                var linkedTablePropsAnalyze = linkedPropsAnalyze.Where(x => x.Value.PropertyAttributes.FirstOrDefault(y => y.GetType() == typeof(LinkedTableAttribute)) != null).Select(x => x.Value).ToList();

                foreach (var linkedTablePropAnalyze in linkedTablePropsAnalyze)
                {
                    var linkedTableLinkedTableInfo = linkedTablePropAnalyze.PropertyAttributes.First(x => x.GetType() == typeof(LinkedTableAttribute)) as LinkedTableAttribute;

                    if (linkedTableLinkedTableInfo.LinkedTableType != currentModule.ModuleItemType)
                        continue;

                    if (linkedTableLinkedTableInfo.LinkedTableRelation == Base.Enum.LinkedTableRelation.Many &&
                        linkedTableInfo.LinkedTableRelation == Base.Enum.LinkedTableRelation.Many)
                        throw new Base.Exceptions.NotSupportedException("Many to many relations for tables are not allowed.");


                    switch (linkedTableInfo.LinkedTableRelation)
                    {
                        case Base.Enum.LinkedTableRelation.One:

                            int linkedNewItemId = (int)typeof(T).GetProperty(propAnalyze.PropertyName).GetValue(item, null);

                            if (linkedTableLinkedTableInfo.LinkedTableRelation == Base.Enum.LinkedTableRelation.Many)
                            {
                                if (oldItem != null)
                                {
                                    int linkedOldItemId = (int)typeof(T).GetProperty(propAnalyze.PropertyName).GetValue(oldItem, null);

                                    if (linkedOldItemId != linkedNewItemId || linkedOldItemId != -1)
                                    {
                                        MethodInfo method = typeof(StorageModule).GetMethod("GetItemById");
                                        MethodInfo genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);

                                        var linkedItem = Convert.ChangeType(genericMethod.Invoke(linkedModule, new object[] { linkedOldItemId }), genericMethod.ReturnType) as AtomicItem;

                                        if (linkedItem != null)
                                        {
                                            var linkedItemLinkedList = linkedItem.GetType().GetProperty(linkedTablePropAnalyze.PropertyName).GetValue(linkedItem, null) as List<int>;
                                            linkedItemLinkedList.Remove(item.Id);

                                            linkedItem.GetType().GetProperty(linkedTablePropAnalyze.PropertyName).SetValue(linkedItem, linkedItemLinkedList);

                                            method = typeof(StorageModule).GetMethod("AddItem");
                                            genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);
                                            genericMethod.Invoke(linkedModule, new object[] { linkedItem, true });
                                        }
                                    }
                                    else
                                        continue;
                                }

                                if (linkedNewItemId != -1)
                                {
                                    MethodInfo method = typeof(StorageModule).GetMethod("GetItemById");
                                    MethodInfo genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);

                                    var linkedItem = Convert.ChangeType(genericMethod.Invoke(linkedModule, new object[] { linkedNewItemId }), genericMethod.ReturnType) as AtomicItem;

                                    if (linkedItem != null)
                                    {
                                        var linkedItemLinkedList = linkedItem.GetType().GetProperty(linkedTablePropAnalyze.PropertyName).GetValue(linkedItem, null) as List<int>;
                                        linkedItemLinkedList.Add(item.Id);

                                        linkedItem.GetType().GetProperty(linkedTablePropAnalyze.PropertyName).SetValue(linkedItem, linkedItemLinkedList);

                                        method = typeof(StorageModule).GetMethod("AddItem");
                                        genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);
                                        genericMethod.Invoke(linkedModule, new object[] { linkedItem, true });
                                    }
                                }
                            }
                            else
                            {
                                MethodInfo method = typeof(StorageModule).GetMethod("GetItemById");
                                MethodInfo genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);

                                var linkedItem = Convert.ChangeType(genericMethod.Invoke(linkedModule, new object[] { linkedNewItemId }), genericMethod.ReturnType) as AtomicItem;

                                if (linkedItem != null)
                                {
                                    linkedItem.GetType().GetProperty(linkedTablePropAnalyze.PropertyName).SetValue(linkedItem, item.Id);

                                    method = typeof(StorageModule).GetMethod("AddItem");
                                    genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);
                                    genericMethod.Invoke(linkedModule, new object[] { linkedItem, true });
                                }
                            }
                            break;

                        case Base.Enum.LinkedTableRelation.Many:

                            List<int> linkedNewItemIds = typeof(T).GetProperty(propAnalyze.PropertyName).GetValue(item, null) as List<int>;
                            List<int> removedIds = new List<int>(), addedIds = new List<int>();

                            if (oldItem != null)
                            {
                                List<int> linkedOldItemIds = typeof(T).GetProperty(propAnalyze.PropertyName).GetValue(oldItem, null) as List<int>;

                                if (linkedOldItemIds != linkedNewItemIds)
                                {
                                    removedIds = linkedOldItemIds.Where(x => !linkedNewItemIds.Contains(x)).ToList();
                                    addedIds = linkedNewItemIds.Where(x => !linkedOldItemIds.Contains(x)).ToList();
                                }
                            }
                            else
                                addedIds = linkedNewItemIds;

                            foreach (var removedId in removedIds)
                            {
                                MethodInfo method = typeof(StorageModule).GetMethod("GetItemById");
                                MethodInfo genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);

                                var linkedItem = Convert.ChangeType(genericMethod.Invoke(linkedModule, new object[] { removedId }), genericMethod.ReturnType) as AtomicItem;

                                if (linkedItem != null)
                                {
                                    linkedItem.GetType().GetProperty(linkedTablePropAnalyze.PropertyName).SetValue(linkedItem, -1);

                                    method = typeof(StorageModule).GetMethod("AddItem");
                                    genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);
                                    genericMethod.Invoke(linkedModule, new object[] { linkedItem, true });
                                }
                            }

                            foreach (var addedId in addedIds)
                            {
                                MethodInfo method = typeof(StorageModule).GetMethod("GetItemById");
                                MethodInfo genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);

                                var linkedItem = Convert.ChangeType(genericMethod.Invoke(linkedModule, new object[] { addedId }), genericMethod.ReturnType) as AtomicItem;

                                if (linkedItem != null)
                                {
                                    linkedItem.GetType().GetProperty(linkedTablePropAnalyze.PropertyName).SetValue(linkedItem, item.Id);

                                    method = typeof(StorageModule).GetMethod("AddItem");
                                    genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);
                                    genericMethod.Invoke(linkedModule, new object[] { linkedItem, false });
                                }
                            }
                            break;

                        default:
                            throw new Base.Exceptions.NotSupportedException("Unsupported relations between tables.");
                    }
                }
            }

            oldItem = null;
        }

        //public IItemManager<BaseItem> CastToGenericType()
        //{
        //    //var thisGenericDefinitionType = typeof(IItemManager<>).GetGenericTypeDefinition();
        //    //var genericItemManagerType2 = thisGenericDefinitionType.MakeGenericType(typeof(T));
        //    //var cxz = Activator.CreateInstance(genericItemManagerType2, dbAccess);
        //    //var xxx = (IItemManager<T>)cxz;
        //    return CastToGenericType(this);


        //    //var genericItemManagerType = GetType().MakeGenericType(typeof(T));
        //    //var xxxx = Activator.CreateInstance(genericItemManagerType, dbAccess);
        //    //var finalType = Activator.CreateInstance(genericItemManagerType, DbAccess).GetType();
        //    //var genericItemManagerType2aa = itemManagerType.MakeGenericType(typeof(BaseItem));
        //    //dynamic xxx = Convert.ChangeType(xxxx, genericItemManagerType2aa);
        //}

        //private IItemManager<BaseItem> CastToGenericType<itemManType>(itemManType itemManagerType)
        //    where itemManType : IItemManager
        //{
        //    var thisGenericDefinitionType = typeof(itemManType).GetGenericTypeDefinition();
        //    var genericItemManagerType2 = thisGenericDefinitionType.MakeGenericType(typeof(T));
        //    var cxz = Activator.CreateInstance(genericItemManagerType2, dbAccess);
        //    var xxx = (IItemManager<T>)cxz;
        //    return (IItemManager<BaseItem>)xxx;
        //    return null;
        //}

        //private async Task AddTimelineItem(T newItem)
        //{
        //    UserActivityChannel _userActivityChannel = UserActivityChannel.GetDefault();
        //    UserActivity _userActivity = await _userActivityChannel.GetOrCreateUserActivityAsync("TDN");

        //    // Fetch the adaptive card JSON
        //    var adaptiveCard = AdaptiveCards.AdaptiveHeaderDescription;

        //    // Replace the content.
        //    adaptiveCard = adaptiveCard.Replace("{backgroundImage}", "");
        //    adaptiveCard = adaptiveCard.Replace("{name}", newItem.Name);
        //    adaptiveCard = adaptiveCard.Replace("{description}", newItem.Description);

        //    // Create the protocol, so when the clicks the Adaptive Card on the Timeline, it will directly launch to the correct image.
        //    //_userActivity.ActivationUri = new Uri($"my-timeline://details?{_galleryItem.ImageSource.Replace("ms-appx:///Assets/Images/", "")}");

        //    // Set the display text to the User Activity(e.g. Pike Place market.)
        //    _userActivity.VisualElements.DisplayText = newItem.Name;

        //    // Assign the Adaptive Card to the user activity. 
        //    _userActivity.VisualElements.Content = AdaptiveCardBuilder.CreateAdaptiveCardFromJson(adaptiveCard);

        //    // Save the details user activity.
        //    await _userActivity.SaveAsync();

        //    // Dispose of the session and create a new one ready for the next user activity.
        //    _userActivitySession?.Dispose();
        //    _userActivitySession = _userActivity.CreateSession();
        //}
    }
}
