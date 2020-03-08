using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    public class RequestMsg
    {
        public string Recipient { get; set; }
        public string Sender { get; set; }
        public object RequestData { get; set; }
    }
}
