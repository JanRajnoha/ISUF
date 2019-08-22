using ISUF.Base.Classes;
using ISUF.Base.Service;
using ISUF.Base.Template;
using ISUF.Security;
using ISUF.Storage.Storage;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Command
{
    public class ShareItemsCommand<T> : Command where T : BaseItem
    {
        private Messenger messenger;

        public ShareItemsCommand(Messenger messenger)
        {
            this.messenger = messenger;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        //Insp -> vlastni typ pripony
        public override void Execute(object parameter)
        {
            if (parameter is ListViewBase itemList)
            {
                if (itemList.Items.Count == 0)
                    return;

                string itemTypeName = itemList.Items[0].GetType().Name;

                var sharedData = new ItemStorage<T>
                {
                    TypeOfItem = itemTypeName
                };

                foreach (var item in new ObservableCollection<T>(itemList.SelectedItems.Cast<T>().Select(x => (T)x.Clone()).ToList()))
                {
                    T itemToShare = item;

                    if (itemToShare.Secured)
                    {
                        itemToShare.Name = Crypting.Encrypt(itemToShare.Name);
                        itemToShare.Description = Crypting.Encrypt(itemToShare.Description);
                    }

                    sharedData.Items.Add(item);
                }

                try
                {
                    XmlSerializer Serializ = new XmlSerializer(typeof(ItemStorage<T>));

                    using (Stream XmlStream = ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync("Share.tdn", CreationCollisionOption.ReplaceExisting).GetAwaiter().GetResult())
                    {
                        Serializ.Serialize(XmlStream, sharedData);
                    }
                }
                catch (Exception e)
                {
                    LogService.AddLogMessage(e.Message, logLevel: Base.Enum.LogLevel.Debug);
                }

                DataTransferManager.ShowShareUI();
            }
        }
    }
}
