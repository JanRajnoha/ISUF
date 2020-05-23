using ISUF.Base.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// Open detail pane for item message
    /// </summary>
    public class ItemDetailOpenMsg : ItemBaseMsg
    {
        /// <summary>
        /// Item index
        /// </summary>
        public int ID { get; set; } = -1;

        /// <summary>
        /// Item was edited
        /// </summary>
        public bool Edit { get; set; } = false;
    }
}
