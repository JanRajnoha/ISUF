using ISUF.UI.EventArgs;
using System;
using System.Linq;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace ISUF.UI.Command
{
    /// <summary>
    /// Command for backuping
    /// </summary>
    public class BackupItemsCommand : Command
    {
        /// <inheritdoc/>
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        /// <inheritdoc/>
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

            var filesList = await ApplicationData.Current.LocalFolder.GetFilesAsync();

            foreach (var item in filesList.Where(x => x.Name.Contains(fileExtension) && (x.Name.IndexOf(fileExtension) + fileExtension.Length == x.Name.Length)))
            {
                await item.CopyAsync(selectedFolder, item.Name, NameCollisionOption.ReplaceExisting);
            }

            CommandCompletedEventArgs args = new CommandCompletedEventArgs()
            {
                CommandName = GetType().Name,
                CommandSuccessful = true,
                ResultText = "Backup was successful"
            };
            CommandCompletedChangedEvent(args);
        }
    }
}