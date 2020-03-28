using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Messages
{
    /// <summary>
    /// Show notification message
    /// </summary>
    public class ShowNotificationMsg
    {
        /// <summary>
        /// Notification text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Duration for showing notification
        /// </summary>
        public int Duration { get; set; } = 5000;
    }
}
