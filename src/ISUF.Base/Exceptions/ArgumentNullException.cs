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
        /// <inheritdoc/>
        public ArgumentNullException() : base()
        {
        }

        /// <inheritdoc/>
        public ArgumentNullException(string paramName) : base(paramName)
        {
        }

        /// <inheritdoc/>
        public ArgumentNullException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <inheritdoc/>
        public ArgumentNullException(string paramName, string message) : base(paramName, message)
        {
        }

        /// <inheritdoc/>
        protected ArgumentNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
