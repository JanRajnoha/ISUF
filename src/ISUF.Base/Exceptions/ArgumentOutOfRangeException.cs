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
    /// <summary>
    /// ISUF Argument out of range exception
    /// </summary>
    public class ArgumentOutOfRangeException : System.ArgumentOutOfRangeException
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ArgumentOutOfRangeException() : base()
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ArgumentOutOfRangeException(string paramName) : base(paramName)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ArgumentOutOfRangeException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ArgumentOutOfRangeException(string paramName, string message) : base(paramName, message)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ArgumentOutOfRangeException(string paramName, object actualValue, string message) : base(paramName, actualValue, message)
        {
        }
    }
}
