using ISUF.Base.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// Item saved from add pane message
    /// </summary>
    public class ItemAddSavedMsg : ItemBaseMsg
    {
        /// <summary>
        /// ID of saved item
        /// </summary>
        public int ID { get; set; } = -1;

        /// <summary>
        /// Add pane closed
        /// </summary>
        public bool ClosePane { get; set; } = true;

        /// <summary>
        /// More items added in row
        /// </summary>
        public bool MoreItemsAdded { get; set; } = false;
    }
}
