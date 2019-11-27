using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Exceptions
{
    public class NotSupportedException : System.NotSupportedException
    {
        public NotSupportedException() : base()
        {
        }

        public NotSupportedException(string message) : base(message)
        {
        }

        public NotSupportedException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        public NotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
