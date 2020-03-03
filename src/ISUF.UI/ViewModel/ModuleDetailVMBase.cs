using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.Base.Template;
using ISUF.Interface.UI;
using ISUF.UI.App;
using ISUF.UI.Modules;
using System;
using System.Linq;
using System.Windows.Input;
using Template10.Mvvm;

namespace ISUF.UI.ViewModel
{
    public abstract class ModuleDetailVMBase<T> : ViewModelBase, IModuleDetailVMBase<T> where T : AtomicItem
    {
        protected Messenger messenger;
        private readonly Type itemType;

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

        protected virtual void DetailOpen(ItemSelectedDetailMsg obj)
        {
            if (obj.ItemType != uiModule.ModuleItemType)
                return;

            DetailItem = uiModule.GetItemById<T>(obj.ID);
        }

        public ICommand Close { get; set; }

        public ModuleDetailVMBase(Messenger messenger, Type modulePage)
        {
            this.messenger = messenger;
            uiModule = (UIModule)ApplicationBase.Current.ModuleManager.GetModules().Where(x => x is UIModule).FirstOrDefault(x => ((UIModule)x).ModulePage == modulePage);
            itemType = uiModule.ModuleItemType;

            Close = new RelayCommand(() => this.messenger.Send(new ItemDetailCloseMsg()
            {
                ItemType = uiModule.ModuleItemType
            }));

            messenger.Register<ItemSelectedDetailMsg>(DetailOpen);
        }
    }
}
