using ISUF.Base.Enum;
using ISUF.Base.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Exceptions
{
    /// <summary>
    /// Not implemented exception with logging
    /// </summary>
    public class NotImplementedException : System.NotImplementedException
    {
        public NotImplementedException()
        {
            LogService.AddLogMessage("Framework Not implemented exception", logLevel: LogLevel.Log);
        }

        public NotImplementedException(string message) : base(message)
        {
            LogService.AddLogMessage("Framework Not implemented exception, message: " + message, logLevel: LogLevel.Log);
        }

        public NotImplementedException(string message, System.Exception inner) : base(message, inner)
        {
            LogService.AddLogMessage("Framework Not implemented exception, message: " + message, logLevel: LogLevel.Log);
        }

        protected NotImplementedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            LogService.AddLogMessage("Framework Not implemented exception", logLevel: LogLevel.Log);
        }
    }
}
