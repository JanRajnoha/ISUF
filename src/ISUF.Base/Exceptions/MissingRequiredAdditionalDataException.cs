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
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public MissingRequiredAdditionalDataException() : base()
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public MissingRequiredAdditionalDataException(string message) : base(message)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public MissingRequiredAdditionalDataException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public MissingRequiredAdditionalDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
