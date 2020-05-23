using ISUF.Base.Classes;
using ISUF.Base.Service;
using ISUF.Base.Template;
using ISUF.Security;
using ISUF.Storage.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Command
{
    /// <summary>
    /// Share items command
    /// </summary>
    /// <typeparam name="T">Item type</typeparam>
    public class ShareItemsCommand<T> : Command where T : BaseItem
    {
        private Messenger messenger;

        /// <summary>
        /// Init share items command
        /// </summary>
        /// <param name="messenger"></param>
        public ShareItemsCommand(Messenger messenger)
        {
            this.messenger = messenger;
        }

        /// <inheritdoc/>
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        //Insp -> vlastni typ pripony
        /// <inheritdoc/>
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

                foreach (var item in new List<T>(itemList.SelectedItems.Cast<T>().Select(x => (T)x.Clone()).ToList()))
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
                    XmlSerializer serializer = new XmlSerializer(typeof(ItemStorage<T>));

                    using Stream xmlStream = ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync("Share.isuf", CreationCollisionOption.ReplaceExisting).GetAwaiter().GetResult();
                    serializer.Serialize(xmlStream, sharedData);
                }
                catch (Exception e)
                {
                    LogService.AddLogMessage(e.Message, logLevel: Base.Enum.LogLevel.Debug);
                    throw new Base.Exceptions.Exception("Unhandled exception", e);
                }

                DataTransferManager.ShowShareUI();
            }
        }
    }
}
