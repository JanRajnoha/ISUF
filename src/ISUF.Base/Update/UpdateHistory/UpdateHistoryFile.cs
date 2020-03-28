using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Update.UpdateHistory
{
    /// <summary>
    /// Update history file structure
    /// </summary>
    public class UpdateHistoryFile
    {
        /// <summary>
        /// Last updated version
        /// </summary>
        public string LastVersion { get; set; }

        /// <summary>
        /// Completed updates
        /// </summary>
        public List<UpdateItem> UpdateList { get; set; }
    }
}

