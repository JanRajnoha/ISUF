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
        /// <summary>
        /// Update type
        /// </summary>
        public T Key { get; set; }

        /// <summary>
        /// Update completed in version
        /// </summary>
        public Version UpdateVersion { get; set; }
    }
}

