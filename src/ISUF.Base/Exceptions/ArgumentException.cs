using System.Runtime.Serialization;

namespace ISUF.Base.Exceptions
{
    /// <summary>
    /// ISUF Argument exception
    /// </summary>
    public class ArgumentException : System.ArgumentOutOfRangeException
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ArgumentException() : base()
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ArgumentException(string message) : base(message)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ArgumentException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected ArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
