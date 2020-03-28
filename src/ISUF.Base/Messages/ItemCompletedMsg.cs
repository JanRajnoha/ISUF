using ISUF.Base.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// Item completed message
    /// </summary>
    public class ItemCompletedMsg : ItemBaseMsg
    {
        /// <summary>
        /// Index of item
        /// </summary>
        public int ID { get; set; } = -1;
    }
}
