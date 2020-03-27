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
    /// ISUF Argument null exception
    /// </summary>
    public class ArgumentNullException : System.ArgumentNullException
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ArgumentNullException() : base()
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ArgumentNullException(string paramName) : base(paramName)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ArgumentNullException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ArgumentNullException(string paramName, string message) : base(paramName, message)
        {
        }

        protected ArgumentNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
