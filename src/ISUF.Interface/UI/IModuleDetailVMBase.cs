using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ISUF.Interface.UI
{
    /// <summary>
    /// Interface for View model for detail items via Detail pane
    /// </summary>
    /// <typeparam name="T">Item type</typeparam>
    public interface IModuleDetailVMBase<T>
    {
        /// <summary>
        /// Item of ViewModel
        /// </summary>
        T DetailItem { get; set; }

        /// <summary>
        /// Close pane command
        /// </summary>
        ICommand Close { get; set; }
    }
}
