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
    public class ArgumentNullException : System.ArgumentOutOfRangeException
    {
        public ArgumentNullException()
        {
        }

        public ArgumentNullException(string message) : base(message)
        {
        }

        public ArgumentNullException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected ArgumentNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
