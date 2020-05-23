using ISUF.Base.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Core;
using Windows.UI.StartScreen;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ISUF.Interface.UI
{
    /// <summary>
    /// Interface for Module View model
    /// </summary>
    /// <typeparam name="T">Item type</typeparam>
    public interface IModuleVMBase<T>
    {
        /// <summary>
        /// Messenger
        /// </summary>
        Messenger Messenger { get; set; }

        /// <summary>
        /// Data transfer manager for items
        /// </summary>
        DataTransferManager DaTranManaItems { get; set; }

        /// <summary>
        /// List view of Items <see cref="ListView"/>
        /// </summary>
        ListViewSelectionMode ListSelectionMode { get; set; }

        /// <summary>
        /// Source of Items
        /// </summary>
        List<T> Source { get; set; }

        /// <summary>
        /// Panes
        /// </summary>
        ObservableCollection<PivotItem> PivotPanes { get; set; }

        /// <summary>
        /// Visibility of pane part
        /// </summary>
        bool PaneVisibility { get; set; }

        /// <summary>
        /// Indicates added start tile for direct access
        /// </summary>
        bool StartTileAdded { get; set; }

        /// <summary>
        /// Notification text
        /// </summary>
        string InAppNotifyText { get; set; }

        /// <summary>
        /// Notification show
        /// </summary>
        bool InAppNotifyShow { get; set; }

        /// <summary>
        /// Name of module
        /// </summary>
        string ModuleName { get; set; }

        /// <summary>
        /// Size of Master column
        /// </summary>
        GridLength MasterFrame { get; set; }

        /// <summary>
        /// Size of Pane column
        /// </summary>
        GridLength SlaveFrame { get; set; }

        /// <summary>
        /// Secodary tile
        /// </summary>
        SecondaryTile SecTile { get; set; }

        /// <summary>
        /// Change pane visibility command
        /// </summary>
        ICommand SlavePaneVisibilityCommand { get; set; }
        
        /// <summary>
        /// Remove items command
        /// </summary>
        ICommand RemoveItemsCommand { get; set; }

        /// <summary>
        /// Select all items from <see cref="ListView"/>
        /// </summary>
        ICommand SelectAllItemsCommand { get; set; }

        /// <summary>
        /// Add second tile to start
        /// </summary>
        ICommand AddStartTileCommand { get; set; }

        /// <summary>
        /// Change pane visibility command
        /// </summary>
        ICommand ChangePaneVisibilityCommand { get; set; }

        /// <summary>
        /// Show add pane command
        /// </summary>
        ICommand AddItemCommand { get; set; }

        /// <summary>
        /// Change type of <see cref="ListViewSelectionMode"/> in <see cref="ListView"/> of Items
        /// </summary>
        ICommand ChangeSelectionModeCommand { get; set; }

        /// <summary>
        /// Show detail pane command
        /// </summary>
        ICommand ShowDetailCommand { get; set; }

        /// <summary>
        /// Remove item command
        /// </summary>
        ICommand RemoveCommand { get; set; }

        /// <summary>
        /// Edit item command
        /// </summary>
        ICommand EditCommand { get; set; }

        /// <summary>
        /// Share items command
        /// </summary>
        ICommand ShareItemsCommand { get; set; }

        /// <summary>
        /// Close current slave pane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CloseCurrentSlavePane(object sender, BackRequestedEventArgs e);

        /// <summary>
        /// Close current pane
        /// </summary>
        void ClosePane();

        /// <summary>
        /// Add secondary tile
        /// </summary>
        void SecTileManageAsync();

        /// <summary>
        /// Inverse pane visibility
        /// </summary>
        void InversePaneVisibility();

        /// <summary>
        /// Form loaded
        /// </summary>
        /// <returns></returns>
        Task Loaded();

        /// <summary>
        /// On load 
        /// </summary>
        /// <param name="SecureChanged">User login status changed</param>
        /// <returns></returns>
        Task OnLoadAsync(bool SecureChanged = false);
    }
}
