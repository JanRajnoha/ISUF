using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    public class ShowNotificationMsg
    {
        public string Text { get; set; }

        public int Duration { get; set; } = 5000;
    }
}
