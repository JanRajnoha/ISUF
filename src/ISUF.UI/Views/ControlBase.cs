using ISUF.Interface.UI;
using ISUF.UI.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Views
{
    public abstract class ControlBase : UserControl, IControlBase
    {
        protected Type viewModelType;
        protected object[] viewModelArgs;

        public ControlBase(Type viewModelType, params object[] viewModelArgs)
        {
            this.viewModelType = viewModelType;
            this.viewModelArgs = viewModelArgs;

            CreateViewModel();

            Loading += ControlBase_Loading;
        }

        protected virtual void ControlBase_Loading(FrameworkElement sender, object args)
        {
            DataContext = ApplicationBase.Current.VMLocator.GetViewModel(viewModelType);
            AddControls();
            CreateControlsForModule();
        }

        protected virtual void CreateViewModel()
        {
            object viewModel = Activator.CreateInstance(viewModelType, viewModelArgs);
            ApplicationBase.Current.VMLocator.AddViewModel(viewModel);
        }

        public abstract void AddControls();

        public abstract void CreateControlsForModule();
    }
}