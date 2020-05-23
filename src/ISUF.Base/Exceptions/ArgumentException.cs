using System.Runtime.Serialization;

namespace ISUF.Base.Exceptions
{
    /// <summary>
    /// ISUF Argument exception
    /// </summary>
    public class ArgumentException : System.ArgumentOutOfRangeException
    {
        /// <inheritdoc/>
        public ArgumentException() : base()
        {
        }

        /// <inheritdoc/>
        public ArgumentException(string message) : base(message)
        {
        }

        /// <inheritdoc/>
        public ArgumentException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <inheritdoc/>
        protected ArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
