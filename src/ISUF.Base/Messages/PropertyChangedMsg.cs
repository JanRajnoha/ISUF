using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    public class PropertyChangedMsg
    {
        public string PropertyName { get; set; }
        public object PropertyValue { get; set; }
        //public Type PropertyParentObjectType { get; set; }
    }
}
