using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using Windows.ApplicationModel.UserActivities;
using ISUF.Base.Template;
using ISUF.Base.Settings;
using ISUF.Security;
using ISUF.Interface;
using ISUF.Base.Service;
using System;

namespace ISUF.Storage.Manager
{
    /// <summary>
    /// Item manager class
    /// </summary>
    public class ItemManager : IItemManager
    {
        protected string id;
        protected string moduleName;
        protected Type moduleItemType;
        protected IDatabaseAccess dbAccess;

        // TODO dopsat
        /// <summary>
        /// Create instance of class for selected file and register UserLogChanged
        /// </summary>
        /// <param name="dbAccess">Database Access object for working with database</param>
        /// <param name="moduleItemType"></param>
        /// <param name="moduleName"></param>
        public ItemManager(IDatabaseAccess dbAccess, Type moduleItemType, string moduleName)
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

        /// <summary>
        /// Add item into collection and save it, when required
        /// </summary>
        /// <param name="item">New item</param>
        /// <param name="saveData">Save data after adding item into collection</param>
        /// <returns>True, if action was succesfull</returns>
        public virtual bool AddItem<T>(T item) where T : BaseItem
        {
            T newItem = item;

            newItem.Encrypted = false;
            newItem.ManagerID = id;

            var itemSource = dbAccess.GetAllItems<T>();

            if (!AddItemAdditionCheck(item))
                return false;

            if (newItem.ID == -1)
            {
                newItem.ID = itemSource != null ? GetID(itemSource) : 0;

                return dbAccess.AddItemIntoDatabase(newItem).Result;
            }
            else
            {
                return dbAccess.UpdateItem(newItem).Result;
            }
        }

        /// <summary>
        /// Add addition check for AddItem
        /// </summary>
        /// <param name="item">New item</param>
        /// <returns>Result of addition check action. True = successful</returns>
        public virtual bool AddItemAdditionCheck<T>(T item) where T : BaseItem
        {
            return true;
        }

        /// <summary>
        /// Add range of items into collection and save it
        /// </summary>
        /// <param name="itemList">List of imported items</param>
        /// <param name="checkItems">Before add check items</param>
        /// <returns>True, if action was succesfull</returns>
        public virtual async Task<bool> AddItemRange<T>(List<T> itemList, bool checkItems = true) where T : BaseItem
        {
            bool res = true;

            foreach (var item in itemList)
            {
                if (checkItems)
                    res &= AddItem(item);
                else
                    res &= await dbAccess.AddItemIntoDatabase(item);

                if (res == false)
                    break;
            }

            return res;
        }

        /// <summary>
        /// Remove item from collection and save it
        /// </summary>
        /// <param name="detailedItem">Removed item</param>
        public virtual async Task<bool> RemoveItem<T>(T detailedItem) where T : BaseItem
        {
            //UpdatePhraseList();

            return await dbAccess.RemoveRow<T>(detailedItem.ID);
        }

        /// <summary>
        /// Get ID for item. If any ID missing, return value of this ID.
        /// If not, return next ID from row.
        /// </summary>
        /// <returns>New ID</returns>
        protected virtual int GetID<T>(ObservableCollection<T> itemSource) where T : BaseItem
        {
            int index = 0;

            var orderedItemSource = itemSource.OrderBy(x => x.ID).ToList();

            for (int i = 0; i < orderedItemSource.Count; i++)
            {
                if (orderedItemSource[i].ID != index)
                    return index;
                else
                    index++;
            }

            return itemSource.Count + 1;
        }

        /// <summary>
        /// Get item from collection
        /// </summary>
        /// <param name="ID">Index of item</param>
        /// <returns>Item</returns>
        public virtual T GetItem<T>(int ID) where T : BaseItem
        {
            return dbAccess.GetItem<T>(ID);
        }

        public void UpdateDatabaseTable()
        {
            dbAccess.UpdateDatabaseTable(moduleItemType);
        }

        public void CreateDatabaseTable()
        {
            dbAccess.CreateDatabaseTable(moduleItemType);
        }

        public void RemoveDatabaseTable()
        {
            dbAccess.RemoveDatabaseTable(moduleItemType);
        }

        /// <summary>
        /// Return list of names of items
        /// </summary>
        /// <returns>List of names of items</returns>
        public virtual async Task<List<string>> GetItemsNameList<T>() where T : BaseItem
        {
            var itemSource = dbAccess.GetAllItems<T>();

            return itemSource?.Select(x => x.Name).ToList() ?? new List<string>();
        }

        /// <summary>
        /// Get collection of valid items
        /// </summary>
        /// <param name="reloadItems">Reload collection after changing security</param>
        /// <returns>Collection of items</returns>
        public virtual async Task<ObservableCollection<T>> GetItemsAsync<T>() where T : BaseItem
        {
            var itemSource = dbAccess.GetAllItems<T>();

            foreach (var item in itemSource)
            {
                item.ManagerID = id;

                if (item.Secured && item.Encrypted)
                {
                    item.Name = Crypting.Decrypt(item.Name);
                    item.Description = Crypting.Decrypt(item.Description);
                    item.Encrypted = false;
                }
            }

            return itemSource;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
