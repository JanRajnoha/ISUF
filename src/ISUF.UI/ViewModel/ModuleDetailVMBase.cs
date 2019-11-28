using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.Base.Template;
using ISUF.Interface.UI;
using System;
using System.Windows.Input;
using Template10.Mvvm;

namespace ISUF.UI.ViewModel
{
    public abstract class ModuleDetailVMBase<T> : Template10.Mvvm.ViewModelBase, IModuleDetailVMBase<T> where T : AtomicItem
    {
        protected Messenger messenger;

        Type ItemType;

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


        public ModuleDetailVMBase(Messenger messenger, Type itemType) : this()
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
