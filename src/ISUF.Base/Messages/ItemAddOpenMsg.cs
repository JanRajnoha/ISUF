using ISUF.Base.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// Open add pane message
    /// </summary>
    public class ItemAddOpenMsg : ItemBaseMsg
    {
        /// <summary>
        /// ID of item opened in add pane
        /// </summary>
        public int ID { get; set; } = -1;
    }
}
