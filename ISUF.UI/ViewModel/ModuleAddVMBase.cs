using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.Base.Settings;
using ISUF.Base.Template;
using ISUF.Base.Service;
using ISUF.Interface;
using ISUF.UI.Controls;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Template10.Mvvm;
using Windows.ApplicationModel.UserActivities;

namespace ISUF.UI.ViewModel
{
    public abstract class ModuleAddVMBase<T> : ViewModelBase, IModuleAddVMBase<T> where T : BaseItem
    {
        public Messenger messenger;
        UserActivitySession currentActivity;
        public bool ModalActivation = false;

        // To-Do solve
        string ItemType;

        public ICommand Close { get; set; }

        private T detailItem;
        public T DetailItem
        {
            get { return detailItem; }
            set
            {
                detailItem = value;
                RaisePropertyChanged(nameof(detailItem));
            }
        }

        private bool secBtnVisibility;
        public bool SecBtnVisibility
        {
            get { return secBtnVisibility; }
            set
            {
                secBtnVisibility = value;
                RaisePropertyChanged(nameof(SecBtnVisibility));
            }
        }

        private bool adVisibility = true;
        public bool AdVisibility
        {
            get { return adVisibility; }
            set
            {
                adVisibility = value;
                RaisePropertyChanged(nameof(AdVisibility));
            }
        }

        private string errorMessage;
        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                errorMessage = value;
                RaisePropertyChanged(nameof(ErrorMessage));
            }
        }

        private bool errorVisible;
        public bool ErrorVisible
        {
            get { return errorVisible; }
            set
            {
                errorVisible = value;
                RaisePropertyChanged(nameof(ErrorVisible));
            }
        }

        private IItemManager<T> manager;
        public IItemManager<T> Manager
        {
            get { return manager; }
            set
            {
                manager = value;
                RaisePropertyChanged(nameof(manager));
            }
        }

        protected abstract void AddNewItem(ItemAddNewMsg obj);
        protected abstract void SelectedItemChanged(ItemSelectedAddMsg obj);

        //  public abstract DelegateCommand<T> SaveItem { get; set; }

        //public abstract DelegateCommand<T> SaveItemClose { get; set; }

        public ModuleAddVMBase()
        {

        }


        // To-Do solve
        public ModuleAddVMBase(Messenger messenger, string itemType) : this()
        {
            this.messenger = messenger;
            ItemType = itemType;

            this.messenger.Register<ItemAddNewMsg>(AddNewItem);

            this.messenger.Register<ItemSelectedAddMsg>(SelectedItemChanged);

            this.messenger.Register<ItemAddErrorMsg>(ErrorInput);
            this.messenger.Register<ItemAddValidMsg>(ValidInput);

            this.messenger.Register<UserLoggedInMsg>(UserLoggedIn);
            this.messenger.Register<UserLoggedOutMsg>(UserLoggedOut);

            Close = new RelayCommand(() => messenger.Send(new ItemAddCloseMsg()
            {
                ItemType = ItemType
            }));

            SecBtnVisibility = CustomSettings.IsUserLogged;

            AdVisibility = !CustomSettings.ShowAds;

            CustomSettings.UserLogChanged += CustomSettings_UserLogChanged;
            CustomSettings.ShowAdsChanged += CustomSettings_ShowAdsChanged;
        }

        public void CloseModal()
        {
            if (ModalActivation)
                ModalWindow.SetVisibility(false);
        }

        public void SetDetailItem(T currentItem)
        {
            DetailItem = currentItem;
        }

        /// <summary>
        /// Change visibility of secured button based on security
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void CustomSettings_UserLogChanged(object sender, UserLoggedEventArgs e)
        {
            SecBtnVisibility = e.UserLoggedNewState;
        }

        /// <summary>
        /// Change visibility of ad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void CustomSettings_ShowAdsChanged(object sender, ShowAdsChangedEventArgs e)
        {
            AdVisibility = !e.ShowAdsChangedNewState;
        }

        // Insp
        protected async Task GenerateTimelineActivityAsync()
        {
            try
            {
                //Get the default UserActivityChannel and query it for our UserActivity. If the activity doesn't exist, one is created.
                UserActivityChannel channel = UserActivityChannel.GetDefault();
                UserActivity userActivity = await channel.GetOrCreateUserActivityAsync("MainPage");

                //Populate required properties
                userActivity.VisualElements.DisplayText = "Hello Activities";
                userActivity.ActivationUri = new Uri("thedailynotes://page2?action=edit");

                //Save
                await userActivity.SaveAsync(); //save the new metadata

                //Dispose of any current UserActivitySession, and create a new one.
                currentActivity?.Dispose();
                currentActivity = userActivity.CreateSession();
            }
            catch (Exception e)
            {
                await LogService.AddLogMessageAsync(e.Message);
            }
        }

        /// <summary>
        /// User Logged out message recieved
        /// </summary>
        /// <param name="obj">Message</param>
        private void UserLoggedOut(UserLoggedOutMsg obj)
        {
            SecBtnVisibility = false;
        }

        /// <summary>
        /// User Logged in message recieved
        /// </summary>
        /// <param name="obj">Message</param>
        private void UserLoggedIn(UserLoggedInMsg obj)
        {
            SecBtnVisibility = true;
        }

        /// <summary>
        /// Values are not valid message recieved
        /// </summary>
        /// <param name="obj">Message</param>
        private async void ErrorInput(ItemAddErrorMsg obj)
        {
            if (obj.ItemType != ItemType)
                return;

            ErrorVisible = true;
            ErrorMessage = obj.Message;

            if (obj.ShowMessage)
            {
                await (new MessageDialog("Error: " + obj.Message, "Error when attempt to save")).ShowAsync();
            }
        }

        /// <summary>
        /// Valid input message recieved
        /// </summary>
        /// <param name="obj">Message</param>
        private void ValidInput(ItemAddValidMsg obj)
        {
            if (obj.ItemType == ItemType)
                ErrorVisible = false;
        }
    }
}
