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

namespace ISUF.Storage.Manager
{
    /// <summary>
    /// Item manager class
    /// </summary>
    /// <typeparam name="T">Type of item</typeparam>
    public class ItemManager<T> : StorageManager<T>, IFake<T>, IItemManager<T> where T : BaseItem
    {
        private string id;
        UserActivitySession _userActivitySession;

        /// <summary>
        /// ID for identiication in Managers collection
        /// </summary>
        public string ID
        {
            get { return id; }
            private set { id = value; }
        }

        /// <summary>
        /// Create instance of class for selected file and register UserLogChanged
        /// </summary>
        /// <param name="fileName"></param>
        public ItemManager(string fileName, string path = "", string id = "") : base(fileName)
        {
            if (id == "")
                ID = fileName;

            var xxx = GetItemsAsync();

            CustomSettings.UserLogChanged += CustomSettings_UserLogChanged;
        }

        /// <summary>
        /// Function for change security event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void CustomSettings_UserLogChanged(object sender, UserLoggedEventArgs e)
        {
            Debug.WriteLine($"User secure settings has changed. Log called from {GetType().ToString()}.");
        }

        /// <summary>
        /// Add item into collection and save it, when required
        /// </summary>
        /// <param name="item">New item</param>
        /// <param name="saveData">Save data after adding item into collection</param>
        /// <returns>True, if action was succesfull</returns>
        public virtual async Task<bool> AddItem(T item, bool saveData = true)
        {
            T NewItem = item;

            NewItem.Encrypted = false;
            NewItem.ManagerID = ID;

            if (ItemsSource == null)
                await GetItemsAsync();

            if (NewItem.ID == -1)
            {
                if (ItemsSource != null)
                    NewItem.ID = GetID();
                else
                    NewItem.ID = 0;

                ItemsSource.Add(NewItem);
            }
            else
            {
                int Index = ItemsSource.IndexOf(ItemsSource.FirstOrDefault(x => x.ID == NewItem.ID));
                if (Index == -1)
                {
                    Index = IndexOfItem(NewItem);
                }

                if (Index == -1)
                {
                    return false;
                }

                ItemsSource.RemoveAt(Index);

                ItemsSource.Insert(Index, NewItem);
            }

            if (!AddItemAdditionCheck(item))
                return false;

            if (saveData)
                await SaveDataAsync();
            else
                ItemsSourceAll.Add(NewItem);

            return true;
        }

        /// <summary>
        /// Add addition check for AddItem
        /// </summary>
        /// <param name="item">New item</param>
        /// <returns>Result of addition check action. True = successful</returns>
        public virtual bool AddItemAdditionCheck(T item)
        {
            return true;
        }

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

        /// <summary>
        /// Add range of items into collection and save it
        /// </summary>
        /// <param name="itemList">List of imported items</param>
        /// <param name="reloadSource">Reload source if null</param>
        /// <returns>True, if action was succesfull</returns>
        public virtual async Task<bool> AddItemRange(List<T> itemList, bool reloadSource = true, bool CheckItems = true)
        {
            bool res = true;

            if (!reloadSource && ItemsSource == null)
            {
                ItemsSource = new ObservableCollection<T>();
                ItemsSourceAll = new ObservableCollection<T>();
            }

            foreach (var item in itemList)
            {
                if (CheckItems)
                    res &= await AddItem(item, false);
                else
                {
                    ItemsSourceAll.Add(item);
                    ItemsSource.Add(item);
                }
            }

            await SaveDataAsync();

            return res;
        }

        /// <summary>
        /// Remove item from collection and save it
        /// </summary>
        /// <param name="detailedItem">Removed item</param>
        public virtual async void Delete(T detailedItem)
        {
            if (ItemsSource == null)
                await GetItemsAsync();

            int index = ItemsSource.IndexOf(detailedItem);

            if (index == -1)
            {
                index = IndexOfItem(detailedItem);
            }

            //UpdatePhraseList();

            ItemsSource.RemoveAt(index);
            await SaveDataAsync();
        }

        /// <summary>
        /// Get ID for item. If any ID missing, return value of this ID.
        /// If not, return next ID from row.
        /// </summary>
        /// <returns>New ID</returns>
        protected virtual int GetID()
        {
            int Index = -1;
            for (int i = 0; i < ItemsSourceAll.Count; i++)
            {
                bool ExistID = false;
                for (int j = 0; j < ItemsSourceAll.Count; j++)
                {
                    if (ItemsSourceAll[j].ID == i + 1)
                    {
                        ExistID = true;
                        break;
                    }
                }

                if (ExistID == false)
                {
                    Index = i + 1;
                    break;
                }
            }

            if (Index == -1)
                Index = ItemsSourceAll.Count + 1;

            return Index;
        }

        /// <summary>
        /// Get item from collection
        /// </summary>
        /// <param name="ID">Index of item</param>
        /// <returns>Item</returns>
        public virtual T GetItem(int ID)
        {
            return ItemsSource[IndexOfItem(ID)];
        }

        /// <summary>
        /// Return list of names of items
        /// </summary>
        /// <returns>List of names of items</returns>
        public virtual async Task<List<string>> GetItemsNameList()
        {
            if ((CustomSettings.IsUserLogged && ItemsSource.Count != ItemsSourceAll.Count) || (!CustomSettings.IsUserLogged && ItemsSource.Count == ItemsSourceAll.Count && ItemsSourceAll.Count(x => x.Secured) > 0))
                await GetItemsAsync(true);

            return ItemsSource?.Select(x => x.Name).ToList() ?? new List<string>();
        }

        /// <summary>
        /// Get source collection of items for serializing
        /// </summary>
        /// <returns>Collection of items</returns>
        protected override ObservableCollection<T> GetFinalCollection()
        {
            foreach (var item in ItemsSource.Where(x => !ItemsSourceAll.Contains(x)))
            {
                if (ItemsSourceAll.FirstOrDefault(x => x.ID == item.ID) != null)
                    ItemsSourceAll[ItemsSourceAll.IndexOf(ItemsSourceAll.FirstOrDefault(x => x.ID == item.ID))] = item;
                else
                    ItemsSourceAll.Add(item);
            }

            bool ClearSecured = CustomSettings.IsUserLogged;

            var ToRemove = ItemsSourceAll.Where(x => (x.Secured == ClearSecured || (x.Secured != ClearSecured && ClearSecured == true))).Where(x => !ItemsSource.Select(y => y.ID).ToList().Contains(x.ID)).Select(x => x.ID).ToList();

            foreach (var item in ToRemove)
            {
                ItemsSourceAll.Remove(ItemsSourceAll.FirstOrDefault(x => x.ID == item));
            }

            return ItemsSourceAll;
        }

        /// <summary>
        /// Get collection of valid items
        /// </summary>
        /// <param name="reloadItems">Reload collection after changing security</param>
        /// <returns>Collection of items</returns>
        public virtual async Task<ObservableCollection<T>> GetItemsAsync(bool reloadItems = false)
        {
            if (ItemsSource == null || reloadItems)
                ItemsSource = await ReadDataAsync();

            foreach (var item in ItemsSource)
            {
                item.ManagerID = ID;

                if (item.Secured && item.Encrypted)
                {
                    item.Name = Crypting.Decrypt(item.Name);
                    item.Description = Crypting.Decrypt(item.Description);
                    item.Encrypted = false;
                }
            }

            return ItemsSource;
        }

        /// <summary>
        /// Save all changes
        /// </summary>
        public async Task SaveChangesAsync()
        {
            await SaveDataAsync();
        }

        /// <summary>
        /// Get index of item in collection by item
        /// </summary>
        /// <param name="examinedItem">item</param>
        /// <returns>Index of item in collection</returns>
        public virtual int IndexOfItem(T examinedItem)
        {
            return IndexOfItem(examinedItem.ID);
        }

        /// <summary>
        /// Get index of item in collection by ID
        /// </summary>
        /// <param name="ID">ID of item</param>
        /// <returns>Index of item in collection</returns>
        public virtual int IndexOfItem(int ID)
        {
            int Index = -1;

            foreach (T task in ItemsSource)
            {
                bool Result = false;

                Result = task.ID == ID;

                Index++;

                if (Result)
                    return Index;
            }

            return -1;
        }

        /// <summary>
        /// Set collection of source items
        /// </summary>
        /// <param name="source">Source collection</param>
        public override void SetSourceCollection(ObservableCollection<T> source)
        {
            ItemsSource = source;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public interface IFake<out T> where T : BaseItem
    { }
}
