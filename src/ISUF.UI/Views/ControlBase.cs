using ISUF.Base.Classes;
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

        /// <summary>
        /// Init control base
        /// </summary>
        /// <param name="viewModelType">View model type</param>
        /// <param name="viewModelArgs">View model arguments</param>
        public ControlBase(Type viewModelType, params object[] viewModelArgs)
        {
            this.viewModelType = viewModelType;
            this.viewModelArgs = viewModelArgs;

            CreateViewModel(true);

            Loading += ControlBase_Loading;
        }

        /// <summary>
        /// Control loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected virtual void ControlBase_Loading(FrameworkElement sender, object args)
        {
            DataContext = ApplicationBase.Current.VMLocator.GetViewModel(viewModelType);
            AddControls();
            CreateControlsForModule();
        }

        /// <summary>
        /// Create view model for control
        /// </summary>
        /// <param name="rewriteViewModel">Rewrite view model in dictionary of view models</param>
        protected virtual void CreateViewModel(bool rewriteViewModel = false)
        {
            Classes.Functions.CreateViewModel(viewModelType, rewriteViewModel, viewModelArgs);
        }

        /// <summary>
        /// Add controls into control
        /// </summary>
        public abstract void AddControls();

        /// <summary>
        /// Create form controls
        /// </summary>
        public abstract void CreateControlsForModule();
    }
}
