using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ISUF.Base.Messages
{
    public class ShowModalActivation
    {
        public IReadOnlyList<IStorageItem> Files { get; set; }
    }
}
