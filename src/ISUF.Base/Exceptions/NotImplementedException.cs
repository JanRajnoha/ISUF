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
    /// ISUF Not implemented exception
    /// </summary>
    public class NotImplementedException : System.NotImplementedException
    {
        /// <inheritdoc/>
        public NotImplementedException() : base()
        {
        }

        /// <inheritdoc/>
        public NotImplementedException(string message) : base(message)
        {
        }

        /// <inheritdoc/>
        public NotImplementedException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <inheritdoc/>
        protected NotImplementedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
