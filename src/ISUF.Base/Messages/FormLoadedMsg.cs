using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// Form loaded message
    /// </summary>
    public class FormLoadedMsg
    {
        /// <summary>
        /// Loaded form type
        /// </summary>
        public Type FormType { get; set; }
    }
}
