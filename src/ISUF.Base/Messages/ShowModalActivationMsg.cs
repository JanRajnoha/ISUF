using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// Modal window activation activated message
    /// </summary>
    public class ShowModalActivationMsg
    {
        /// <summary>
        /// Files for modal window
        /// </summary>
        public IReadOnlyList<IStorageItem> Files { get; set; }
    }
}
