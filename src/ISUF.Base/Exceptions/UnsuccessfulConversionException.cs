using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Exceptions
{
    public class UnsuccessfulConversionException : Exception
    {
        public UnsuccessfulConversionException() : base()
        {
        }

        public UnsuccessfulConversionException(string message) : base(message)
        {
        }

        public UnsuccessfulConversionException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected UnsuccessfulConversionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
