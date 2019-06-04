using ISUF.UI.EventArgs;
using System;
using System.Linq;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace ISUF.UI.Command
{
    public class ImportItemsCommand : Command
    {
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public async override void Execute(object parameter)
        {
            if (!(parameter is string fileExtension))
                return;
            else if (!fileExtension.Contains('.') || fileExtension.IndexOf('.') != 0)
                fileExtension = "." + fileExtension;

            FolderPicker backupLocation = new FolderPicker
            {
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary
            };

            backupLocation.FileTypeFilter.Add(fileExtension);
            var selectedFolder = await backupLocation.PickSingleFolderAsync();

            var filesList = await selectedFolder.GetFilesAsync();

            foreach (var item in filesList.Where(x => x.Name.Contains(fileExtension) && (x.Name.IndexOf(fileExtension) + fileExtension.Length == x.Name.Length)))
            {
                await item.CopyAsync(ApplicationData.Current.LocalFolder, item.Name, NameCollisionOption.ReplaceExisting);
            }

            CommandCompletedEventArgs args = new CommandCompletedEventArgs()
            {
                CommandName = GetType().Name,
                CommandSuccessful = true,
                ResultText = "Import was successful"
            };
            CommandCompletedChangedEvent(args);
        }
    }
}