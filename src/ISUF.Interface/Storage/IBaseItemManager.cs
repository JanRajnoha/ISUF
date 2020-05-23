using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Interface.Storage
{
    /// <summary>
    /// Base item manager interface
    /// </summary>
    public interface IBaseItemManager : IAtomicItemManager
    {
        /// <summary>
        /// Get names of all items
        /// </summary>
        /// <typeparam name="T">Type of item</typeparam>
        /// <returns>List of all names for selected type of item</returns>
        List<string> GetItemsNameList<T>() where T : BaseItem;
    }
}
