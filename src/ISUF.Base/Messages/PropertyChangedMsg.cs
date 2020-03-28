using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// Property changed message
    /// </summary>
    public class PropertyChangedMsg
    {
        /// <summary>
        /// Property name
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Property value
        /// </summary>
        public object PropertyValue { get; set; }

        /// <summary>
        /// Parent object of property
        /// </summary>
        public Type PropertyParentObjectType { get; set; }
    }
}
