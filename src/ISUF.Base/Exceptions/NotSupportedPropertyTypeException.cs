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
    /// ISUF Not supported property exception
    /// </summary>
    public class NotSupportedPropertyTypeException : NotSupportedException
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotSupportedPropertyTypeException() : base()
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotSupportedPropertyTypeException(string message) : base(message)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotSupportedPropertyTypeException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotSupportedPropertyTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
