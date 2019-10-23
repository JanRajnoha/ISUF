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
    public class VMLocator
    {
        private readonly Messenger messenger = new Messenger();

        public Dictionary<Type, object> ViewModels { get; set; }

        public bool AddViewModel(object newViewModel)
        {
            if (!ViewModels.ContainsKey(newViewModel.GetType()))
            {
                ViewModels.Add(newViewModel.GetType(), newViewModel);
                return true;
            }
            else
                return false;
        }

        public object GetViewModel(Type viewModelType)
        {   
            var viewModel = ViewModels.GetValueOrDefault(viewModelType);
            return Convert.ChangeType(viewModel, viewModelType) ?? null;
        }

        public void SendMessage(ShowModalActivationMsg showModalActivation)
        {
            messenger.Send(showModalActivation);
        }

        public Messenger GetMessenger()
        {
            return messenger;
        }
    }
}
