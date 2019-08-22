using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Update.UpdateHistory
{
    /// <summary>
    /// Update history item structure
    /// </summary>
    public class UpdateHistoryItem<T>
    {
        public T Key { get; set; }
        public Version UpdateVersion { get; set; }
    }
}

