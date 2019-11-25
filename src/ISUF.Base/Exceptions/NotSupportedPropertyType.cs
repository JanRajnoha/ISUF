using ISUF.Base.Enum;
using ISUF.Base.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Exceptions
{
    public class NotSupportedPropertyType : NotSupportedException
    {
        public NotSupportedPropertyType() : base()
        {
        }

        public NotSupportedPropertyType(string message) : base(message)
        {
        }

        public NotSupportedPropertyType(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        public NotSupportedPropertyType(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
