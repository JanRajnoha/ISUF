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

        protected virtual IList<FrameworkElement> GetControlsFromForm()
        {
            return Classes.Functions.GetControlsByName(form, Classes.Constants.DATA_CONTROL_IDENTIFIER, true);
        }

        public void FillValuesFromFormIntoItem()
        {
            var formControls = GetControlsFromForm();

            FillValues(formControls);
        }

        protected virtual void SaveItem()
        {
            FillValuesFromFormIntoItem();

            uiModule.AddItem(AddEditItem);
        }

        private void SaveCloseItem()
        {
            SaveItem();
            CloseAddPane();
        }

        private void FillValues(IList<FrameworkElement> formControls)
        {
            var itemProps = typeof(T).GetProperties();

            foreach (var formControl in formControls)
            {
                var formControlName = formControl.Name.Substring(0, formControl.Name.Length - Classes.Constants.DATA_CONTROL_IDENTIFIER.Length);
                var itemProp = itemProps.FirstOrDefault(x => x.Name == formControlName);

                if (itemProp == null)
                    throw new Base.Exceptions.ArgumentException("None of controls not match property name.");

                object value = GetValueFromControl(formControl);

                if (value.GetType() != itemProp.PropertyType)
                    value = ConvertValueToPropValue(value, itemProp);

                itemProp.SetValue(AddEditItem, value);
            }
        }

        private object ConvertValueToPropValue(object value, PropertyInfo prop)
        {
            object convertedValue;
            bool conversionResult = true;

            if (value.GetType() == typeof(string))
                if (prop.PropertyType == typeof(int))
                {
                    conversionResult = int.TryParse(value as string, out int convertedNumber);
                    convertedValue = convertedNumber;
                }
                else if (prop.PropertyType == typeof(byte))
                {
                    conversionResult = byte.TryParse(value as string, out byte convertedNumber);
                    convertedValue = convertedNumber;
                }
                else if (prop.PropertyType == typeof(double))
                {
                    conversionResult = double.TryParse(value as string, out double convertedNumber);
                    convertedValue = convertedNumber;
                }
                else if (prop.PropertyType == typeof(decimal))
                {
                    conversionResult = decimal.TryParse(value as string, out decimal convertedNumber);
                    convertedValue = convertedNumber;
                }
                else if (prop.PropertyType == typeof(float))
                {
                    conversionResult = float.TryParse(value as string, out float convertedNumber);
                    convertedValue = convertedNumber;
                }
                else if (prop.PropertyType == typeof(char))
                    return value;
                else
                    throw new Base.Exceptions.NotSupportedException("Not supported type conversion between control and property. \n" +
                    $"Value type: {value.GetType()}\n\n" +
                    $"Target type: {prop.PropertyType}");
            else if (value.GetType() == typeof(TimeSpan))
                convertedValue = DateTime.Today + (TimeSpan)value;
            else if (value.GetType() == typeof(DateTimeOffset))
                convertedValue = ((DateTimeOffset)value).DateTime;
            else
                throw new Base.Exceptions.NotSupportedException("Not supported type conversion between control and property. \n" +
                    $"Value type: {value.GetType()}\n" +
                    $"Target type: {prop.PropertyType}");

            if (!conversionResult)
                throw new Base.Exceptions.UnsuccessfulConversionException("Conversion was unsuccessful. \n" +
                    $"Value type: {value.GetType().ToString()}\n" +
                    $"Target type: {prop.PropertyType.Name}");

            return convertedValue;
        }

        private object GetValueFromControl(FrameworkElement formControl)
        {
            if (formControl.GetType() == typeof(TextBox))
                return (formControl as TextBox).Text;
            else if (formControl.GetType() == typeof(LinkedTablePresenterControl))
                return (formControl as LinkedTablePresenterControl).GetSelectedIds();
            else if (formControl.GetType() == typeof(LinkedTableSelectorControl))
                return (formControl as LinkedTableSelectorControl).GetSelectedId();
            else if (formControl.GetType() == typeof(CalendarDatePicker))
                return (formControl as CalendarDatePicker).Date;
            else if (formControl.GetType() == typeof(TimePicker))
                return (formControl as TimePicker).Time;
            else if (formControl.GetType() == typeof(CheckBox))
                return (formControl as CheckBox).IsChecked;
            else
                throw new Base.Exceptions.NotSupportedException("Not supported type of control for getting value.");
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
