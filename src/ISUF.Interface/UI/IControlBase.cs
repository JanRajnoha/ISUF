using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Interface.UI
{
    /// <summary>
    /// Interface for dynamically created controls
    /// </summary>
    public interface IControlBase
    {
        /// <summary>
        /// Add controls into <see cref="UserControl"/>
        /// </summary>
        void AddControls();

        /// <summary>
        /// Dynamically create controls for form
        /// </summary>
        void CreateControlsForModule();
    }
}
