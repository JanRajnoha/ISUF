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
    /// ISUF exception
    /// </summary>
    public class Exception : System.Exception
    {
        /// <inheritdoc/>
        public Exception() : base()
        {
        }

        /// <inheritdoc/>
        public Exception(string message) : base(message)
        {
        }

        /// <inheritdoc/>
        public Exception(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc/>
        protected Exception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
