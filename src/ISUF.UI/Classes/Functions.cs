using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

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

        public static T FindControl<T>(UIElement parent, Type targetType, string ControlName) where T : FrameworkElement
        {
            if (parent == null) return null;

            if (parent.GetType() == targetType && ((T)parent).Name == ControlName)
            {
                return (T)parent;
            }
            T result = null;
            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                UIElement child = (UIElement)VisualTreeHelper.GetChild(parent, i);

                if (child is ContentControl contentChild && contentChild.Content is UIElement innerContent)
                {
                    if (contentChild.Name == ControlName)
                        return (T)child;

                    child = innerContent;
                }

                if (FindControl<T>(child, targetType, ControlName) != null)
                {
                    result = FindControl<T>(child, targetType, ControlName);
                    break;
                }
            }
            return result;
        }
    }
}
