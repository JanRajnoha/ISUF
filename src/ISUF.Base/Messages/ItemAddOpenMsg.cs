using ISUF.Base.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    public class ItemAddOpenMsg : ItemBaseMsg
    {
        public int ID { get; set; } = -1;
    }
}
