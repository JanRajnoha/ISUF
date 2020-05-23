using ISUF.Base.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// Item edited message
    /// </summary>
    public class ItemEditMsg : ItemBaseMsg
    {
        /// <summary>
        /// Item index
        /// </summary>
        public int ID { get; set; } = -1;
    }
}
