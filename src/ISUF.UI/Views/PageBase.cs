using ISUF.Interface.UI;
using ISUF.UI.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Views
{
    /// <summary>
    /// Base for app page
    /// </summary>
    public abstract class PageBase : Page, IPageBase
    {
        protected Type viewModelType;
        protected object[] viewModelArgs;

        /// <summary>
        /// Init base for page
        /// </summary>
        /// <param name="viewModelType">View model type</param>
        /// <param name="viewModelArgs">View model arguments</param>
        public PageBase(Type viewModelType, params object[] viewModelArgs)
        {
            this.viewModelType = viewModelType;
            this.viewModelArgs = viewModelArgs;

            CreateViewModel();

            Loading += ModulePageBase_Loading;
        }

        /// <summary>
        /// Page loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected virtual void ModulePageBase_Loading(FrameworkElement sender, object args)
        {
            DataContext = ApplicationBase.Current.VMLocator.GetViewModel(viewModelType);
            AddControls();
        }

        /// <summary>
        /// Create view model
        /// </summary>
        protected virtual void CreateViewModel()
        {
            Classes.Functions.CreateViewModel(viewModelType, viewModelArgs: viewModelArgs);
        }

        /// <summary>
        /// Add controls into page
        /// </summary>
        public abstract void AddControls();
    }
}
