using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Exceptions
{
    public class MissingRequiredAdditionalDataException : Exception
    {
        public MissingRequiredAdditionalDataException() : base()
        {
        }

        public MissingRequiredAdditionalDataException(string message) : base(message)
        {
        }

        public MissingRequiredAdditionalDataException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        public MissingRequiredAdditionalDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
