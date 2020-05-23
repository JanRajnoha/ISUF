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
    /// <summary>
    /// View model base for detail pane
    /// </summary>
    /// <typeparam name="T">Type of item</typeparam>
    public abstract class ModuleDetailVMBase<T> : ViewModelBase, IModuleDetailVMBase<T> where T : AtomicItem
    {
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

        /// <summary>
        /// Open detail pane message recieved
        /// </summary>
        /// <param name="obj">Selected detail item message</param>
        protected virtual void DetailOpen(ItemSelectedDetailMsg obj)
        {
            if (obj.ItemType != uiModule.ModuleItemType)
                return;

            DetailItem = uiModule.GetItemById<T>(obj.ID);
        }

        public ICommand Close { get; set; }

        /// <summary>
        /// Init view model bease for detail pane
        /// </summary>
        /// <param name="messenger">Messenger</param>
        /// <param name="modulePage">Module page</param>
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
