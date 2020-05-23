using ISUF.Base.Classes;
using ISUF.Base.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.UI.Classes
{
    /// <summary>
    /// VM Locator
    /// </summary>
    public class VMLocator
    {
        private readonly Messenger messenger = new Messenger();

        /// <summary>
        /// View models dictionary
        /// </summary>
        public Dictionary<Type, object> ViewModels { get; set; } = new Dictionary<Type, object>();

        /// <summary>
        /// Add view model
        /// </summary>
        /// <param name="newViewModel">New view model</param>
        /// <param name="rewriteViewModel">Rewerite view model in dictionary</param>
        /// <returns>Result of adding new view model</returns>
        public bool AddViewModel(object newViewModel, bool rewriteViewModel = false)
        {
            if (newViewModel == null)
                throw new Base.Exceptions.ArgumentNullException("ViewModel is null.");

            if (!ViewModels.ContainsKey(newViewModel.GetType()))
            {
                ViewModels.Add(newViewModel.GetType(), newViewModel);
                return true;
            }
            else if (rewriteViewModel)
            {
                ViewModels[newViewModel.GetType()] = newViewModel;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Get view model by type
        /// </summary>
        /// <param name="viewModelType">View model type</param>
        /// <returns>View model</returns>
        public object GetViewModel(Type viewModelType)
        {   
            var viewModel = ViewModels.GetValueOrDefault(viewModelType);
            return Convert.ChangeType(viewModel, viewModelType) ?? null;
        }

        /// <summary>
        /// Get messenger
        /// </summary>
        /// <returns>Messenger</returns>
        public Messenger GetMessenger()
        {
            return messenger;
        }
    }
}
