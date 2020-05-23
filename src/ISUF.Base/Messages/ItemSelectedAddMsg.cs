using ISUF.Base.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// Show add pane for selected item message
    /// </summary>
    public class ItemSelectedAddMsg : ItemBaseMsg
    {
        /// <summary>
        /// Item index
        /// </summary>
        public int ID { get; set; } = -1;
    }
}
