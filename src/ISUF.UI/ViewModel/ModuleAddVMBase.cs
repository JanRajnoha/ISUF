using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.Base.Settings;
using ISUF.Base.Template;
using ISUF.Base.Service;
using ISUF.UI.Controls;
using ISUF.UI.Classes;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Template10.Mvvm;
using Windows.ApplicationModel.UserActivities;
using ISUF.Interface.UI;
using ISUF.Interface.Storage;
using ISUF.UI.App;
using ISUF.UI.Modules;
using System.Linq;
using ISUF.UI.Design;
using ISUF.UI.Views;
using Windows.UI.Xaml;
using System.Collections.Generic;
using System.Reflection;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.ViewModel
{
    public abstract class ModuleAddVMBase<T> : ViewModelBase, IModuleAddVMBase<T> where T : BaseItem
    {
        readonly ModuleAddControlBase form;
        readonly Type itemType;

        UserActivitySession currentActivity;

        public bool ModalActivation { get; set; } = false;

        public ICommand Close { get; set; }

        private T addEditItem;
        public T AddEditItem
        {
            get { return addEditItem; }
            set
            {
                addEditItem = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), AddEditItem);
            }
        }

        private bool secBtnVisibility;
        public bool SecBtnVisibility
        {
            get { return secBtnVisibility; }
            set
            {
                secBtnVisibility = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), SecBtnVisibility);
            }
        }

        private bool adVisibility = true;
        public bool AdVisibility
        {
            get { return adVisibility; }
            set
            {
                adVisibility = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), AdVisibility);
            }
        }

        private string errorMessage;
        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                errorMessage = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), ErrorMessage);
            }
        }

        private bool errorVisible;
        public bool ErrorVisible
        {
            get { return errorVisible; }
            set
            {
                errorVisible = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), ErrorVisible);
            }
        }

        // todo smazat
        //private IBaseItemManager manager;
        //public IBaseItemManager Manager
        //{
        //    get { return manager; }
        //    set
        //    {
        //        manager = value;
        //        PropertyChangedNotifier.NotifyPropertyChanged(GetType(), Manager);
        //    }
        //}

        protected abstract void AddNewItem(ItemAddNewMsg obj);
        protected abstract void SelectedItemChanged(ItemSelectedAddMsg obj);

        public virtual DelegateCommand<T> SaveItemCommand => new DelegateCommand<T>(async (T item) => { SaveItem(); });

        public virtual DelegateCommand<T> SaveItemCloseCommand => new DelegateCommand<T>(async (T item) => { SaveCloseItem(); });

        public ModuleAddVMBase()
        {

        }


        // To-Do solve
        public ModuleAddVMBase(Messenger messenger, Type modulePage, ModuleAddControlBase form) : this()
        {
            this.messenger = messenger;
            this.modulePage = modulePage;
            this.form = form;

            this.messenger.Register<ItemAddNewMsg>(AddNewItem);

            this.messenger.Register<ItemSelectedAddMsg>(SelectedItemChanged);

            this.messenger.Register<ItemAddErrorMsg>(ErrorInput);
            this.messenger.Register<ItemAddValidMsg>(ValidInput);

            this.messenger.Register<UserLoggedInMsg>(UserLoggedIn);
            this.messenger.Register<UserLoggedOutMsg>(UserLoggedOut);

            Close = new RelayCommand(() => CloseAddPane());

            SecBtnVisibility = CustomSettings.IsUserLogged;

            AdVisibility = !CustomSettings.ShowAds;

            CustomSettings.UserLogChanged += CustomSettings_UserLogChanged;
            CustomSettings.ShowAdsChanged += CustomSettings_ShowAdsChanged;

            uiModule = (UIModule)ApplicationBase.Current.ModuleManager.GetModules().Where(x => x is UIModule).FirstOrDefault(x => ((UIModule)x).ModulePage == modulePage);
            itemType = uiModule.ModuleItemType;
        }

        private void CloseAddPane()
        {
            messenger.Send(new ItemAddCloseMsg()
            {
                ItemType = itemType
            });
        }

        public void CloseModal()
        {
            if (ModalActivation)
                ModalWindow.SetVisibility(false);
        }

        public void SetDetailItem(T currentItem)
        {
            AddEditItem = currentItem;
        }

        protected virtual void SaveItem()
        {
            FillValuesFromFormIntoItem();
            uiModule.AddItem(AddEditItem);
        }

        public void FillValuesFromFormIntoItem()
        {
            var formControls = FormDataMiner.GetControlsFromForm(form);
            AddEditItem = FormDataMiner.FillValuesIntoProperty(formControls, AddEditItem);
        }

        private void SaveCloseItem()
        {
            SaveItem();
            CloseAddPane();
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
                throw new Base.Exceptions.Exception("Unhandled exception", e);
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
            if (obj.ItemType != itemType)
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
            if (obj.ItemType == itemType)
                ErrorVisible = false;
        }
    }
}
