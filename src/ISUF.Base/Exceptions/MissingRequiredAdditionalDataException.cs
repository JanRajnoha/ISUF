using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Exceptions
{
    /// <summary>
    /// ISUF Missing required additional data exception
    /// </summary>
    public class MissingRequiredAdditionalDataException : Exception
    {
        /// <inheritdoc/>
        public MissingRequiredAdditionalDataException() : base()
        {
        }

        /// <inheritdoc/>
        public MissingRequiredAdditionalDataException(string message) : base(message)
        {
        }

        /// <inheritdoc/>
        public MissingRequiredAdditionalDataException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc/>
        public MissingRequiredAdditionalDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
