using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.Base.Template;
using ISUF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Template10.Mvvm;

namespace ISUF.UI.ViewModel
{
    public abstract class ModuleDetailVMBase<T> : ViewModelBase, IModuleDetailVMBase<T> where T : BaseItem
    {
        protected Messenger messenger;

        // To-Do solve
        string ItemType;

        private T detailItem;
        public T DetailItem
        {
            get { return detailItem; }
            set
            {
                detailItem = value;
                RaisePropertyChanged(nameof(DetailItem));
            }
        }

        protected abstract void DetailOpen(ItemSelectedDetailMsg obj);

        public ICommand Close { get; set; }

        public ModuleDetailVMBase()
        {

        }


        // To-Do solve
        public ModuleDetailVMBase(Messenger messenger, string itemType) : this()
        {
            this.messenger = messenger;
            ItemType = itemType;

            Close = new RelayCommand(() => this.messenger.Send(new ItemDetailCloseMsg()
            {
                ItemType = ItemType
            }));

            messenger.Register<ItemSelectedDetailMsg>(DetailOpen);
        }
    }
}
