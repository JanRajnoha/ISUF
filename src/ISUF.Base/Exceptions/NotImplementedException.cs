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
    /// <summary>
    /// Not implemented exception with logging
    /// </summary>
    public class NotImplementedException : System.NotImplementedException
    {
        public NotImplementedException() : base()
        {
        }

        public NotImplementedException(string message) : base(message)
        {
        }

        public NotImplementedException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected NotImplementedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
