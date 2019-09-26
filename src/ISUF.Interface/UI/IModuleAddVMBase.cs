using ISUF.Base.Template;
using ISUF.Interface.Storage;
using System.Windows.Input;

namespace ISUF.Interface.UI
{
    public interface IModuleAddVMBase<T> where T : AtomicItem
    {
        ICommand Close { get; set; }

        T DetailItem { get; set; }

        bool SecBtnVisibility { get; set; }

        string ErrorMessage { get; set; }

        bool ErrorVisible { get; set; }

        IAtomicItemManager Manager { get; set; }

        void SetDetailItem(T currentItem);

        //   DelegateCommand<T> SaveItem { get; set; }

        // DelegateCommand<T> SaveItemClose { get; set; }
    }
}
