using System.Runtime.Serialization;

namespace ISUF.Base.Exceptions
{
    /// <summary>
    /// ISUF Not supported attribute combination exception
    /// </summary>
    public class NotSupportedAttributeCombinationException : ArgumentOutOfRangeException
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotSupportedAttributeCombinationException() : base()
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotSupportedAttributeCombinationException(string message) : base(message)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public NotSupportedAttributeCombinationException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        protected NotSupportedAttributeCombinationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
