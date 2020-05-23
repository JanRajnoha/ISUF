using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Modules
{
    /// <summary>
    /// Model of module item showed in app
    /// </summary>
    public class AppModuleItem
    {
        public string ModuleDisplayName { get; set; }

        public Symbol ModuleDisplayIcon { get; set; }

        public Type ModulePage { get; set; }

        public AppModuleItem(string moduleDisplayName, Type modulePage, Symbol moduleDisplayIcon)
        {
            ModuleDisplayName = moduleDisplayName;
            ModuleDisplayIcon = moduleDisplayIcon;
            ModulePage = modulePage;
        }
    }
}
