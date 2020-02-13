using System.Runtime.Serialization;

namespace ISUF.Base.Exceptions
{
    public class ArgumentException : System.ArgumentOutOfRangeException
    {
        public ArgumentException() : base()
        {
        }

        public ArgumentException(string message) : base(message)
        {
        }

        public ArgumentException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected ArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
