using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ISUF.Base.Enum;
using ISUF.Base.Service;

namespace ISUF.Base.Exceptions
{
    public class ArgumentOutOfRangeException : System.ArgumentOutOfRangeException
    {
        public ArgumentOutOfRangeException() : base()
        {
        }

        public ArgumentOutOfRangeException(string paramName) : base(paramName)
        {
        }

        public ArgumentOutOfRangeException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public ArgumentOutOfRangeException(string paramName, string message) : base(paramName, message)
        {
        }

        public ArgumentOutOfRangeException(string paramName, object actualValue, string message) : base(paramName, actualValue, message)
        {
        }
    }
}
