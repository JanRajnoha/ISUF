using ISUF.Base.Template;
using ISUF.Interface.Storage;
using System.Windows.Input;

namespace ISUF.Interface.UI
{
    /// <summary>
    /// Interface for View model for adding items via Add pane
    /// </summary>
    /// <typeparam name="T">Item type</typeparam>
    public interface IModuleAddVMBase<T> where T : AtomicItem
    {
        /// <summary>
        /// Close pane command
        /// </summary>
        ICommand Close { get; set; }

        /// <summary>
        /// Item of ViewModel
        /// </summary>
        T AddEditItem { get; set; }

        /// <summary>
        /// Visibility of secured button for add pane
        /// </summary>
        bool SecBtnVisibility { get; set; }

        /// <summary>
        /// Error message for add pane
        /// </summary>
        string ErrorMessage { get; set; }

        /// <summary>
        /// Visibility of error message for add pane
        /// </summary>
        bool ErrorVisible { get; set; }

        /// <summary>
        /// Set current item
        /// </summary>
        /// <param name="currentItem">New item to be set</param>
        void SetAddEditItem(T currentItem);
    }
}
