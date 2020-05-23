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
        /// <inheritdoc/>
        public NotSupportedPropertyTypeException() : base()
        {
        }

        /// <inheritdoc/>
        public NotSupportedPropertyTypeException(string message) : base(message)
        {
        }

        /// <inheritdoc/>
        public NotSupportedPropertyTypeException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc/>
        public NotSupportedPropertyTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
