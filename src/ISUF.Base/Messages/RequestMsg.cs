using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// Request message
    /// </summary>
    public class RequestMsg
    {
        /// <summary>
        /// Recipient
        /// </summary>
        public string Recipient { get; set; }

        /// <summary>
        /// Sender
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// What data are requested
        /// </summary>
        public object RequestData { get; set; }
    }
}
