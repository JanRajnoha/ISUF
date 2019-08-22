using ISUF.Base.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    public class ItemAddErrorMsg : ItemBaseMsg
    {
        public string Message { get; set; }

        public string UIElement { get; set; }

        public bool DisableUI { get; set; } = false;

        public bool ShowMessage { get; set; } = true;
    }
}
