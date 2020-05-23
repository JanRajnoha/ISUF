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
    /// <summary>
    /// View model base for add pane
    /// </summary>
    /// <typeparam name="T">Type of item</typeparam>
    public abstract class ModuleAddVMBase<T> : ViewModelBase, IModuleAddVMBase<T> where T : BaseItem
    {
        private readonly ModuleAddControlBase form;
        private readonly Type itemType;

        public bool ModalActivation { get; set; } = false;

        public ICommand Close { get; set; }

        private T addEditItem;
        public T AddEditItem
        {
            get { return addEditItem; }
            set
            {
                addEditItem = value;
                FillValuesFromItemIntoForm();
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

        public virtual DelegateCommand<T> SaveItemCommand => new DelegateCommand<T>(async (T item) => { SaveItem(); });

        public virtual DelegateCommand<T> SaveItemCloseCommand => new DelegateCommand<T>(async (T item) => { SaveCloseItem(); });

        /// <summary>
        /// Init add item view model base
        /// </summary>
        public ModuleAddVMBase()
        {

        }

        /// <summary>
        /// Init add item view model base
        /// </summary>
        /// <param name="messenger">Messenger</param>
        /// <param name="modulePage">Module page</param>
        /// <param name="form">Form for adding controls</param>
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

        /// <summary>
        /// Close add pane
        /// </summary>
        private void CloseAddPane()
        {
            messenger.Send(new ItemAddCloseMsg()
            {
                ItemType = itemType
            });
        }

        /// <summary>
        /// Add new item message recieved
        /// </summary>
        /// <param name="obj">Add new item message</param>
        protected virtual void AddNewItem(ItemAddNewMsg obj)
        {
            if (obj != null && obj.ItemType != typeof(T))
                return;

            AddEditItem = Base.Classes.Functions.CreateInstance(typeof(T)) as T;
        }

        /// <summary>
        /// Selected item changed message recieved
        /// </summary>
        /// <param name="obj">Selected item changed message</param>
        protected virtual void SelectedItemChanged(ItemSelectedAddMsg obj)
        {
            if (obj == null || (obj != null && obj.ID == -1))
                AddEditItem = Base.Classes.Functions.CreateInstance(typeof(T)) as T;
            else
                AddEditItem = uiModule.GetItemById<T>(obj.ID);
        }

        /// <summary>
        /// Close modal
        /// </summary>
        public void CloseModal()
        {
            // TODO
        }

        /// <summary>
        /// Set selected item
        /// </summary>
        /// <param name="currentItem">New selected item</param>
        public void SetAddEditItem(T currentItem)
        {
            AddEditItem = currentItem;
        }

        /// <summary>
        /// Save item
        /// </summary>
        protected virtual void SaveItem()
        {
            bool newItem = AddEditItem.Id == -1;

            FillValuesFromFormIntoItem();

            ItemAddSavedMsg msg = new ItemAddSavedMsg()
            {
                ID = AddEditItem.Id,
                ItemType = itemType
            };

            uiModule.AddItem(AddEditItem);

            messenger.Send(msg);

            AddEditItem = Base.Classes.Functions.CreateInstance(typeof(T)) as T;

            if (!newItem)
                CloseAddPane();
        }

        /// <summary>
        /// Fill values from form into item
        /// </summary>
        private void FillValuesFromFormIntoItem()
        {
            var formControls = FormDataMiner.GetControlsFromForm(form);
            AddEditItem = FormDataMiner.FillValuesIntoProperty(formControls, AddEditItem);
        }

        /// <summary>
        /// Fill values from item into form
        /// </summary>
        private void FillValuesFromItemIntoForm()
        {
            if (form == null)
                return;

            var formControls = FormDataMiner.GetControlsFromForm(form);
            FormDataMiner.FillValuesIntoForm(formControls, AddEditItem);
        }

        /// <summary>
        /// Save item and close pane
        /// </summary>
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
        //protected async Task GenerateTimelineActivityAsync()
        //{
        //    try
        //    {
        //        //Get the default UserActivityChannel and query it for our UserActivity. If the activity doesn't exist, one is created.
        //        UserActivityChannel channel = UserActivityChannel.GetDefault();
        //        UserActivity userActivity = await channel.GetOrCreateUserActivityAsync("MainPage");

        //        //Populate required properties
        //        userActivity.VisualElements.DisplayText = "Hello Activities";
        //        userActivity.ActivationUri = new Uri("thedailynotes://page2?action=edit");

        //        //Save
        //        await userActivity.SaveAsync(); //save the new metadata

        //        //Dispose of any current UserActivitySession, and create a new one.
        //        currentActivity?.Dispose();
        //        currentActivity = userActivity.CreateSession();
        //    }
        //    catch (Exception e)
        //    {
        //        await LogService.AddLogMessageAsync(e.Message);
        //        throw new Base.Exceptions.Exception("Unhandled exception", e);
        //    }
        //}

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
