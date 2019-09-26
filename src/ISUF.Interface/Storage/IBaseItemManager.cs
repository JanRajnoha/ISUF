using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Interface.Storage
{
    public interface IBaseItemManager : IAtomicItemManager
    {
        List<string> GetItemsNameList<T>() where T : BaseItem;
    }
}
