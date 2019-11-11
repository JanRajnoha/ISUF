using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.Base.Service;
using ISUF.Base.Settings;
using ISUF.Base.Template;
using ISUF.Interface.UI;
using ISUF.Storage.Storage;
using ISUF.UI.App;
using ISUF.UI.Command;
using ISUF.UI.Design;
using ISUF.UI.Modules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml;
using System.Xml.Serialization;
using Template10.Mvvm;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Core;
using Windows.UI.StartScreen;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ISUF.UI.ViewModel
{
    public abstract class ModuleVMBase<T> : ViewModelBase, IModuleVMBase<T> where T : BaseItem
    {
        protected const string addPivotItemName = "AddPivot";
        protected const string detailPivotItemName = "DetailPivot";
        public const string ShareFileName = "Share.isuf";
        protected string shareMessage = string.Empty;
        protected string shareHtml;
        protected UIModule uiModule;

        // To-Do solve
        string ItemType;

        private Messenger messenger;
        public Messenger Messenger
        {
            get => messenger;
            set
            {
                messenger = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), Messenger);
            }
        }

        private DataTransferManager daTranManaItems;
        public DataTransferManager DaTranManaItems
        {
            get => daTranManaItems;
            set
            {
                daTranManaItems = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), DaTranManaItems);
            }
        }

        private ListViewSelectionMode listSelectionMode;
        public ListViewSelectionMode ListSelectionMode
        {
            get => listSelectionMode;
            set
            {
                listSelectionMode = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), ListSelectionMode);
            }
        }

        private ObservableCollection<T> source = new ObservableCollection<T>();
        public ObservableCollection<T> Source
        {
            get => source;
            set
            {
                source = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), Source);
            }
        }

        private ObservableCollection<PivotItem> pivotPanes;
        public ObservableCollection<PivotItem> PivotPanes
        {
            get => pivotPanes;
            set
            {
                pivotPanes = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), PivotPanes);
            }
        }

        private bool paneVisibility;
        public bool PaneVisibility
        {
            get => paneVisibility;
            set
            {
                paneVisibility = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), PaneVisibility);
            }
        }

        private bool startTileAdded;
        public bool StartTileAdded
        {
            get => startTileAdded;
            set
            {
                startTileAdded = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), StartTileAdded);
            }
        }

        private string inAppNotifyText;
        public string InAppNotifyText
        {
            get => inAppNotifyText;
            set
            {
                inAppNotifyText = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), InAppNotifyText);
            }
        }

        private bool inAppNotifyShow = false;
        public bool InAppNotifyShow
        {
            get => inAppNotifyShow;
            set
            {
                inAppNotifyShow = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), InAppNotifyShow);
            }
        }

        private string moduleName;
        public string ModuleName
        {
            get => moduleName;
            set
            {
                moduleName = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), ModuleName);
            }
        }

        private GridLength masterFrame;
        public GridLength MasterFrame
        {
            get => masterFrame;
            set
            {
                masterFrame = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), MasterFrame);
            }
        }

        private GridLength slaveFrame;
        public GridLength SlaveFrame
        {
            get => slaveFrame;
            set
            {
                slaveFrame = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), SlaveFrame);
            }
        }

        private string moduleTitle;
        public string ModuleTitle
        {
            get => moduleTitle;
            set
            {
                moduleTitle = value;
                PropertyChangedNotifier.NotifyPropertyChanged(GetType(), ModuleTitle);
            }
        }

        public SecondaryTile SecTile { get; set; }

        public ICommand SlavePaneVisibilityCommand { get; set; }

        public ICommand DeleteItems { get; set; }

        public ICommand SelectAllItems { get; set; }

        public ICommand ShareItems { get; set; }

        public ICommand AddStartTile { get; set; }

        public ICommand ChangePaneVisibility { get; set; }

        public ICommand AddItem { get; set; }

        public ICommand ChangeSelectionMode { get; set; }

        public ICommand DetailCommand { get; set; }

        public ICommand EditCommand { get; set; }

        protected abstract void AddPane<TMessage>(string paneName, TMessage msg);
        protected abstract void NewItemAdded(ItemAddSavedMsg obj);
        protected abstract Task UpdateSourceAsync(bool secureChanged = false);

        public abstract Task OnLoadAsync(bool SecureChanged = false);

        public ModuleVMBase(Type modulePage)
        {
            Messenger = ApplicationBase.Current.VMLocator.GetMessenger();
            PivotPanes = new ObservableCollection<PivotItem>();

            PaneVisibility = false;
            MasterFrame = new GridLength(1, GridUnitType.Star);
            SlaveFrame = new GridLength(0);

            DataTransferManager daTranManaItems = DataTransferManager.GetForCurrentView();

            ChangeSelectionMode = new RelayCommand(() =>
            {
                if (ListSelectionMode == ListViewSelectionMode.None)
                    ListSelectionMode = ListViewSelectionMode.Multiple;
                else
                    ListSelectionMode = ListViewSelectionMode.None;
            });

            Messenger.Register<ItemAddCloseMsg>(CloseAddPane);
            AddItem = new RelayCommand(ItemNew);

            Messenger.Register<ItemAddSavedMsg>(NewItemAdded);
            Messenger.Register<ItemEditMsg>(EditItem);

            Messenger.Register<ItemDetailOpenMsg>(OpenDetailPane);
            Messenger.Register<ItemDetailCloseMsg>(CloseDetailPane);

            AddStartTile = new RelayCommand(() => SecTileManageAsync());
            ChangePaneVisibility = new RelayCommand(InversePaneVisibility);

            ShareItems = new DelegateCommand<ListViewBase>((ListViewBase selectedItems) =>
            {
                daTranManaItems = DataTransferManager.GetForCurrentView();
                daTranManaItems.DataRequested += DaTranManaItems_DataRequestedAsync;
                new ShareItemsCommand<T>(Messenger).Execute(selectedItems);
            });

            CustomSettings.UserLogChanged += CustomSettings_UserLogChanged;

            uiModule = (UIModule)ApplicationBase.Current.ModuleManager.GetModules().Where(x => x is UIModule).FirstOrDefault(x => ((UIModule)x).ModulePage == modulePage);
            ModuleTitle = uiModule.ModuleDisplayName;
            ModuleName = uiModule.ModuleName;
        }

        // To-Do solve
        public ModuleVMBase(Type modulePage, SecondaryTile secondaryTile, string itemType) : this(modulePage)
        {
            SecTile = secondaryTile;
            StartTileAdded = SecondaryTile.Exists(SecTile.TileId) ? true : false;
            ItemType = itemType;
        }

        protected abstract void ShowModal(ShowModalActivationMsg obj);

        /// <summary>
        /// Prepare package for share
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected virtual void DaTranManaItems_DataRequestedAsync(DataTransferManager sender, DataRequestedEventArgs args)
        {
            shareHtml +=
                "<br><br>Open via The Daily Notes<br>" +
                "Get app from <a href=\"https://www.microsoft.com/store/productId/9NBLGGH69J83\">Microsoft Store<\\a><br>";

            string htmlExport = HtmlFormatHelper.CreateHtmlFormat(shareHtml);

            DataRequest dReq = args.Request;
            dReq.Data.SetHtmlFormat(htmlExport);
            dReq.Data.ShareCompleted += Data_ShareCompleted;

            daTranManaItems = DataTransferManager.GetForCurrentView();
            daTranManaItems.DataRequested -= DaTranManaItems_DataRequestedAsync;
        }

        private void Data_ShareCompleted(DataPackage sender, ShareCompletedEventArgs args)
        {
            messenger.Send(new ShowNotificationMsg()
            {
                Text = shareMessage
            });
        }

        protected virtual void CustomSettings_UserLogChanged(object sender, UserLoggedEventArgs e)
        {
            OnLoadAsync(true);
        }

        /// <summary>
        /// Set Back button to close current pane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CloseCurrentSlavePane(object sender, BackRequestedEventArgs e)
        {
            PaneVisibility = false;
            e.Handled = true;
        }

        public void ClosePane()
        {
            if (PivotPanes.Count == 0)
            {
                PaneVisibility = false;
                MasterFrame = new GridLength(1, GridUnitType.Star);
            }
        }

        /// <summary>
        /// Create or delete secondary tile for activities
        /// </summary>
        public async void SecTileManageAsync()
        {
            if (SecondaryTile.Exists(SecTile.TileId))
            {
                await SecTile.RequestDeleteAsync();
                StartTileAdded = false;
            }
            else
            {
                SecTile.VisualElements.ShowNameOnSquare150x150Logo = true;
                SecTile.VisualElements.ForegroundText = ForegroundText.Light;
                SecTile.RoamingEnabled = true;

                await SecTile.RequestCreateAsync();

                if (SecondaryTile.Exists(SecTile.TileId))
                    StartTileAdded = true;
            }
        }

        /// <summary>
        /// Get collection of activites
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="mode"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            Messenger.Register<ShowModalActivationMsg>(ShowModal);
            await Task.CompletedTask;
        }

        /// <summary>
        /// Set ShowAddActPage to custom settings ShowPanelAfterLeavePage
        /// </summary>
        /// <param name="pageState"></param>
        /// <param name="suspending"></param>
        /// <returns></returns>
        public override async Task OnNavigatedFromAsync(IDictionary<string, object> pageState, bool suspending)
        {
            //foreach (var Item in ShowSlaveActPage.ToList())
            //{
            //    ShowSlaveActPage[Item.Key] = Services.SettingsServices.SettingsService.Instance.ShowPanelAfterLeavePage && Item.Value;
            //}

            if (!SettingsService.Instance.ShowPanelAfterLeavePage)
            {
                PivotPanes.Clear();
            }

            Messenger.UnRegister<ShowModalActivationMsg>(ShowModal);

            await Task.CompletedTask;
        }

        /// <summary>
        /// Hide or show pane
        /// </summary>
        public void InversePaneVisibility()
        {
            PaneVisibility = !PaneVisibility;

            double MinNormalWidth = (double)Application.Current.Resources["NormalMinWidth"];
            if (MinNormalWidth > ApplicationView.GetForCurrentView().VisibleBounds.Width)
            {
                if (PaneVisibility)
                    MasterFrame = new GridLength(0);
                else
                    MasterFrame = new GridLength(1, GridUnitType.Star);
            }
        }

        /// <summary>
        /// Set default values
        /// </summary>
        /// <returns></returns>
        public virtual async Task Loaded()
        {
            await OnLoadAsync();

            if (PivotPanes.Count == 0)
            {
                PaneVisibility = false;
            }
        }

        /// <summary>
        /// Decode type of item
        /// </summary>
        /// <param name="fileXmlString">Decoded XML</param>
        /// <returns>Type of item</returns>

        // To-Do solve - nullable type
        public string CategoryDecode(string fileXmlString)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(fileXmlString);

            var helper = new ItemStorage<AtomicItem>();
            var sel = xmlDoc.SelectSingleNode("//" + nameof(helper.TypeOfItem));

            if (sel == null)
                return null;


            // To-Do solve
            //var typeOfItemList = System.Enum.GetValues(typeof(ItemTypeEnum)).Cast<ItemTypeEnum>().ToList();
            //return typeOfItemList[typeOfItemList.IndexOf(typeOfItemList.FirstOrDefault(x => x.ToString() == sel.InnerText))];

            return sel.InnerText;
        }

        /// <summary>
        /// Decode XML file
        /// </summary>
        /// <typeparam name="T">Type of item</typeparam>
        /// <param name="fileXmlString">XML file</param>
        /// <returns>Collection of items</returns>
        protected ItemStorage<ItemType> DecodeItemFile<ItemType>(string fileXmlString) where ItemType : AtomicItem
        {
            StringReader stringReader = new StringReader(fileXmlString);
            XmlReader xmlReader = XmlReader.Create(stringReader);
            XmlSerializer serializer = new XmlSerializer(typeof(ItemStorage<T>));
            return (ItemStorage<ItemType>)serializer.Deserialize(xmlReader);
        }

        /// <summary>
        /// Close add pane message recieved
        /// </summary>
        /// <param name="obj">Message</param>
        protected void CloseAddPane(ItemAddCloseMsg obj)
        {
            if (obj != null)
                if (obj.ItemType != ItemType)
                    return;

            PivotPanes.Remove(PivotPanes.Where(x => x.Name == addPivotItemName)?.FirstOrDefault());

            ClosePane();
        }

        /// <summary>
        /// Open detail pane message recieved
        /// </summary>
        /// <param name="obj">Message</param>
        protected void OpenDetailPane(ItemDetailOpenMsg obj)
        {
            if (obj.ItemType == ItemType)
                AddPane(detailPivotItemName, new ItemSelectedDetailMsg()
                {
                    ItemType = ItemType,
                    ID = obj.ID,
                    Edit = obj.Edit,
                    ManagerID = obj.ManagerID
                });
        }

        /// <summary>
        /// Close detail pane message recieved
        /// </summary>
        /// <param name="obj">Message</param>
        protected void CloseDetailPane(ItemDetailCloseMsg obj)
        {
            if (obj.ItemType != ItemType)
                return;

            PivotPanes.Remove(PivotPanes.Where(x => x.Name == detailPivotItemName)?.FirstOrDefault());

            ClosePane();
        }

        /// <summary>
        /// Edit item message recieved
        /// </summary>
        /// <param name="obj">Message</param>
        protected void EditItem(ItemEditMsg obj)
        {
            if (obj != null)
            {
                if (obj.ItemType == ItemType)
                    AddPane(addPivotItemName, new ItemSelectedAddMsg()
                    {
                        ItemType = ItemType,
                        ID = obj.ID,
                        ManagerID = obj.ManagerID
                    });
            }
        }

        /// <summary>
        /// Open add pane
        /// </summary>
        /// <param name="obj"></param>
        private void ItemNew(object obj)
        {
            AddPane(addPivotItemName, new ItemAddNewMsg()
            {
                ItemType = ItemType
            });
        }
    }
}
