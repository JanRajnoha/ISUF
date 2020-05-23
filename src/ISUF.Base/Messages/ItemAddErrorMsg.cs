using ISUF.Base.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// While adding item error occured message
    /// </summary>
    public class ItemAddErrorMsg : ItemBaseMsg
    {
        /// <summary>
        /// Error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// UI element, which caused error
        /// </summary>
        public string UIElement { get; set; }

        /// <summary>
        /// Disable UI
        /// </summary>
        public bool DisableUI { get; set; } = false;

        /// <summary>
        /// Show message
        /// </summary>
        public bool ShowMessage { get; set; } = true;
    }
}
