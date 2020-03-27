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
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotImplementedException() : base()
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotImplementedException(string message) : base(message)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotImplementedException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        protected NotImplementedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
