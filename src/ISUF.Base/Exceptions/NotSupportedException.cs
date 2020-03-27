using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Exceptions
{
    /// <summary>
    /// ISUF Not supported exception
    /// </summary>
    public class NotSupportedException : System.NotSupportedException
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotSupportedException() : base()
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotSupportedException(string message) : base(message)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotSupportedException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
