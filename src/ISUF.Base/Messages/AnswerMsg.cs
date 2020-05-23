using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// Answer message
    /// </summary>
    public class AnswerMsg
    {
        /// <summary>
        /// Recipient (sender in request message)
        /// </summary>
        public string Recipient { get; set; }

        /// <summary>
        /// Sender (recipient in request message)
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        public object AnswerData { get; set; }
    }
}
