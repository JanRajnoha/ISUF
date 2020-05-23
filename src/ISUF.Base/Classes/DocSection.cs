using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Classes
{
    /// <summary>
    /// Structure of paragraph - Document section
    /// </summary>
    public class DocSection
    {
        /// <summary>
        /// Title of document section
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Content of document section
        /// </summary>
        public string Content { get; set; }
    }
}