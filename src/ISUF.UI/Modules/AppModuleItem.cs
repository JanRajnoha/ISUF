using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.UI.Modules
{
    public class AppModuleItem
    {
        public string ModuleDisplayName { get; set; }

        public string ModuleDisplayIcon { get; set; }

        public AppModuleItem(string moduleDisplayName, string moduleDisplayIcon)
        {
            ModuleDisplayName = moduleDisplayName;
            ModuleDisplayIcon = moduleDisplayIcon;
        }
    }
}
