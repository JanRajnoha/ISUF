using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.UI.Design
{
    public class RegisteredTargetProperty
    {
        public string PropertyName { get; set; }
        public Type PropertyParentObjectType { get; set; }
        public string PropertyInnerPropertyName { get; set; }
    }
}
