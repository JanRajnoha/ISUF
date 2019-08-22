using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ISUF.Interface
{
    public interface IModuleDetailVMBase<T>
    {
        T DetailItem { get; set; }

        ICommand Close { get; set; }
    }
}
