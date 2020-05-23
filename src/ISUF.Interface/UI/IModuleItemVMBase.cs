using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ISUF.Interface.UI
{
    /// <summary>
    /// View model for one oitem
    /// </summary>
    /// <typeparam name="T">Item type</typeparam>
    public interface IModuleItemVMBase<T>
    {
        /// <summary>
        /// Current item
        /// </summary>
        T CurrentItem { get; set; }

        /// <summary>
        /// Share command
        /// </summary>
        ICommand ShareCommand { get; set; }

        /// <summary>
        /// Edit command
        /// </summary>
        ICommand EditCommand { get; set; }
    }
}
