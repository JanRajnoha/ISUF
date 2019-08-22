using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.UI.Classes
{
    class Functions
    {
        /// <summary>
        /// Invert color
        /// </summary>
        /// <param name="defaultColor">Color to inversion</param>
        /// <returns>Inverted color</returns>
        public static System.Drawing.Color InvertColor(System.Drawing.Color defaultColor)
        {
            return System.Drawing.Color.FromArgb(defaultColor.ToArgb() ^ 0xffffff);
        }

        /// <summary>
        /// Invert color
        /// </summary>
        /// <param name="defaultColor">Color to inversion</param>
        /// <returns>Inverted color</returns>
        public static Windows.UI.Color InvertColor(Windows.UI.Color defaultColor)
        {
            return Windows.UI.Color.FromArgb(
                defaultColor.A,
                (byte)(255 - defaultColor.R),
                (byte)(255 - defaultColor.G),
                (byte)(255 - defaultColor.B));
        }
    }
}
