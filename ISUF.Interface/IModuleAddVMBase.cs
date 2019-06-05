using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ISUF.Interface
{
    public interface IModuleAddVMBase<T>
    {
        ICommand Close { get; set; }

        T DetailItem { get; set; }

        bool SecBtnVisibility { get; set; }

        string ErrorMessage { get; set; }

        bool ErrorVisible { get; set; }

        IItemManager<T> Manager { get; set; }

        void SetDetailItem(T currentItem);

        //   DelegateCommand<T> SaveItem { get; set; }

        // DelegateCommand<T> SaveItemClose { get; set; }
    }
}
