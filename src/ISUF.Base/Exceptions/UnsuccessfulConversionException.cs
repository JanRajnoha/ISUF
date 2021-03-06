using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Exceptions
{
    /// <summary>
    /// ISUF Unsuccessful conversion exception
    /// </summary>
    public class UnsuccessfulConversionException : Exception
    {
        /// <inheritdoc/>
        public UnsuccessfulConversionException() : base()
        {
        }

        /// <inheritdoc/>
        public UnsuccessfulConversionException(string message) : base(message)
        {
        }

        /// <inheritdoc/>
        public UnsuccessfulConversionException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc/>
        protected UnsuccessfulConversionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
