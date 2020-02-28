using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.Base.Service;
using ISUF.Base.Template;
using ISUF.Security;
using ISUF.Storage.Storage;
using ISUF.Interface.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Input;
using System.Xml.Serialization;
using Template10.Mvvm;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;

namespace ISUF.UI.ViewModel
{
    public abstract class ModuleItemVMBase<T> : Template10.Mvvm.ViewModelBase, IModuleItemVMBase<T> where T : BaseItem
    {
        public Messenger messenger;
        const string ShareFileItem = "Share.isuf";
        protected string shareMessage = string.Empty;
        protected string shareHtml;

        Type ItemType;

        protected List<StorageFile> shareFileList;

        private DataTransferManager daTranManaItem;
        public DataTransferManager DaTranManaItem
        {
            get { return daTranManaItem; }
            set
            {
                daTranManaItem = value;
                RaisePropertyChanged(nameof(DaTranManaItem));
            }
        }

        public ICommand ShareCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public ICommand DetailCommand => new DelegateCommand<AtomicItem>((AtomicItem item) =>
        {
            messenger.Send(new ItemDetailOpenMsg()
            {
                ItemType = ItemType,
                Edit = false,
                ID = item.Id,
                ManagerID = item.ManagerID
            });
        });

        private T currentItem;
        public T CurrentItem
        {
            get { return currentItem; }
            set { currentItem = value; }
        }

        public ModuleItemVMBase()
        {
            DataTransferManager daTranManaItem = DataTransferManager.GetForCurrentView();
        }


        // To-Do solve
        public ModuleItemVMBase(Messenger messenger, Type itemType) : this()
        {
            this.messenger = messenger;
            ItemType = itemType;

            EditCommand = new DelegateCommand<AtomicItem>(EditItem);
            ShareCommand = new DelegateCommand<T>(ShareItemAsync);
        }

        /// <summary>
        /// Share item via Share menu
        /// </summary>
        /// <param name="obj">Shared item</param>
        public async void ShareItemAsync(T item)
        {
            DataTransferManager daTranManaItem = DataTransferManager.GetForCurrentView();
            daTranManaItem.DataRequested += DaTranManaItem_DataRequested;

            string itemTypeName = item.GetType().Name;

            if (item == null)
            {
                return;
            }

            CurrentItem = item;

            // To-Do solve
            //var typeOfItemList = System.Enum.GetValues(typeof(ItemTypeEnum)).Cast<ItemTypeEnum>().ToList();

            var clone = (T)item.Clone();

            if (item.Secured)
            {
                clone.Name = Crypting.Encrypt(item.Name);
                clone.Description = Crypting.Encrypt(item.Description);
            }

            var sharedData = new ItemStorage<T>
            {

                // To-Do solve
                //TypeOfItem = typeOfItemList[typeOfItemList.IndexOf(typeOfItemList.FirstOrDefault(x => x.ToString() == itemTypeName))],
                TypeOfItem = itemTypeName,
                Items = new List<T>()
                {
                    clone
                }
            };

            try
            {
                XmlSerializer Serializ = new XmlSerializer(typeof(ItemStorage<T>));

                using (Stream XmlStream = ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(ShareFileItem, CreationCollisionOption.ReplaceExisting).GetAwaiter().GetResult())
                {
                    Serializ.Serialize(XmlStream, sharedData);
                }
            }
            catch (Exception e)
            {
                LogService.AddLogMessage(e.Message);
                throw new Base.Exceptions.Exception("Unhandled exception", e);
            }

            var shareFile = await ApplicationData.Current.LocalFolder.GetFileAsync(ShareFileItem);

            shareFileList = new List<StorageFile>
            {
                shareFile
            };

            DataTransferManager.ShowShareUI();
        }

        /// <summary>
        /// Preparing data for sharing -> Message text, links, ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected virtual void DaTranManaItem_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            shareHtml +=
                "<br><br>Open via The Daily Notes<br>" +
                "Get app from <a href=\"https://www.microsoft.com/store/productId/9NBLGGH69J83\">Microsoft Store<\\a><br>";

            string htmlExport = HtmlFormatHelper.CreateHtmlFormat(shareHtml);

            DataRequest dReq = args.Request;
            dReq.Data.SetHtmlFormat(htmlExport);
            dReq.Data.Properties.ApplicationName = Windows.ApplicationModel.Package.Current.DisplayName;
            dReq.Data.Properties.ApplicationListingUri = new Uri(@"https://www.microsoft.com/store/productId/9NBLGGH69J83\");

            dReq.Data.ShareCompleted += Data_ShareCompleted;

            DataTransferManager daTranManaItem = DataTransferManager.GetForCurrentView();
            daTranManaItem.DataRequested -= DaTranManaItem_DataRequested;
        }

        private void Data_ShareCompleted(DataPackage sender, ShareCompletedEventArgs args)
        {
            messenger.Send(new ShowNotificationMsg()
            {
                Text = shareMessage
            });
        }

        /// <summary>
        /// Send message about selected item to edit
        /// </summary>
        /// <param name="obj">Selected item</param>
        protected void EditItem(AtomicItem obj)
        {
            messenger.Send(new ItemEditMsg()
            {
                ItemType = ItemType,
                ID = obj.Id,
                ManagerID = obj.ManagerID
            });
        }

        //public void ShareItem()
        //{

        //}
    }
}
