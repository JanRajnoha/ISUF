using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.UI.EventArgs
{
    /// <summary>
    /// Command completed event args
    /// </summary>
    public class CommandCompletedEventArgs
    {
        public string CommandName { get; set; }
        public string ResultText { get; set; }
        public bool CommandSuccessful { get; set; }
    }
}
