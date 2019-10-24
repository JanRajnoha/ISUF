using ISUF.Base.Classes;
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
        public UIModuleManager ModuleManager { get; set; }

        private Messenger messenger;
        public Messenger Messenger
        {
            get { return messenger; }
            set
            {
                messenger = value;
                RaisePropertyChanged(nameof(Messenger));
            }
        }
    }
}
