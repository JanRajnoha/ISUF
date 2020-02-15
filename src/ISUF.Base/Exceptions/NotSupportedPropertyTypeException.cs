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
    public class NotSupportedPropertyTypeException : NotSupportedException
    {
        public NotSupportedPropertyTypeException() : base()
        {
        }

        public NotSupportedPropertyTypeException(string message) : base(message)
        {
        }

        public NotSupportedPropertyTypeException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        public NotSupportedPropertyTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
