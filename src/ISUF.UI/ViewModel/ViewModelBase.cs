using ISUF.Base.Classes;
using ISUF.UI.Design;
using ISUF.UI.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.UI.ViewModel
{
    public class ViewModelBase : Template10.Mvvm.ViewModelBase
    {
        //public UIModuleManager ModuleManager { get; set; }

        protected Messenger messenger;
        protected UIModule uiModule;
        protected Type modulePage;

        //public Messenger Messenger
        //{
        //    get => messenger;
        //    set
        //    {
        //        messenger = value;
        //        PropertyChangedNotifier.NotifyPropertyChanged(GetType(), Messenger);
        //    }
        //}

        public object GetPropertyValue(string propertyName)
        {
            return GetType().GetProperty(propertyName).GetValue(this, null);
        }
    }
}
