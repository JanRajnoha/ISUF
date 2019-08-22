using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Update.UpdateHistory
{
    /// <summary>
    /// Update item structure for serialization
    /// </summary>
    public class UpdateItem
    {
        public string Key { get; set; }
        public bool UpdateDone { get; set; } = false;
    }
}
