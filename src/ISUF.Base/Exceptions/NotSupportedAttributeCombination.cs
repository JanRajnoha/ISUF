using System.Runtime.Serialization;

namespace ISUF.Base.Exceptions
{
    public class NotSupportedAttributeCombination : ArgumentOutOfRangeException
    {
        public NotSupportedAttributeCombination() : base()
        {
        }

        public NotSupportedAttributeCombination(string message) : base(message)
        {
        }

        public NotSupportedAttributeCombination(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected NotSupportedAttributeCombination(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
