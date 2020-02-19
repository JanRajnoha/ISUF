using ISUF.Base.Template;
using ISUF.Interface.Storage;
using System.Windows.Input;

namespace ISUF.Interface.UI

{
    public interface IModuleAddVMBase<T> where T : AtomicItem
    {
        ICommand Close { get; set; }

        T AddEditItem { get; set; }

        bool SecBtnVisibility { get; set; }

        string ErrorMessage { get; set; }

        bool ErrorVisible { get; set; }

        void SetDetailItem(T currentItem);
    }
}
