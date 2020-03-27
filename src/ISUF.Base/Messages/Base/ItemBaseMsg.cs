using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages.Base
{
    /// <summary>
    /// Base message for item message
    /// </summary>
    public class ItemBaseMsg
    {
        /// <summary>
        /// Type of item in msg
        /// </summary>
        public Type ItemType { get; set; }
    }
}
