using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ISUF.Interface.UI
{
    /// <summary>
    /// Interface for page
    /// </summary>
    public interface IPageBase
    {
        /// <summary>
        /// Add controls into <see cref="Page"/>
        /// </summary>
        void AddControls();
    }
}
