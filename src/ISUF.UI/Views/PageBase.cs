using ISUF.Interface.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Views
{
    public abstract class PageBase : Page, IPageBase
    {
        public abstract void AddControls();
    }
}
