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
    public abstract class PageBase : Page, IPageBase
    {
        protected Type viewModelType;
        protected object[] viewModelArgs;

        public PageBase(Type viewModelType, params object[] viewModelArgs)
        {
            this.viewModelType = viewModelType;
            this.viewModelArgs = viewModelArgs;

            CreateViewModel();

            Loading += ModulePageBase_Loading;
        }

        protected virtual void ModulePageBase_Loading(FrameworkElement sender, object args)
        {
            DataContext = ApplicationBase.Current.VMLocator.GetViewModel(viewModelType);
            AddControls();
        }

        protected virtual void CreateViewModel()
        {
            object viewModel = Activator.CreateInstance(viewModelType, viewModelArgs);
            ApplicationBase.Current.VMLocator.AddViewModel(viewModel);
        }

        public abstract void AddControls();
    }
}
