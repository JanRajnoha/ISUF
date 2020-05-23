using System.Runtime.Serialization;

namespace ISUF.Base.Exceptions
{
    /// <summary>
    /// ISUF Not supported attribute combination exception
    /// </summary>
    public class NotSupportedAttributeCombinationException : ArgumentOutOfRangeException
    {
        /// <inheritdoc/>
        public NotSupportedAttributeCombinationException() : base()
        {
        }

        /// <inheritdoc/>
        public NotSupportedAttributeCombinationException(string message) : base(message)
        {
        }

        /// <inheritdoc/>
        public NotSupportedAttributeCombinationException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <inheritdoc/>
        protected NotSupportedAttributeCombinationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
