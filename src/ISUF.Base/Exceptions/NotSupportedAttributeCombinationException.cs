using System.Runtime.Serialization;

namespace ISUF.Base.Exceptions
{
    public class NotSupportedAttributeCombinationException : ArgumentOutOfRangeException
    {
        public NotSupportedAttributeCombinationException() : base()
        {
        }

        public NotSupportedAttributeCombinationException(string message) : base(message)
        {
        }

        public NotSupportedAttributeCombinationException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected NotSupportedAttributeCombinationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
