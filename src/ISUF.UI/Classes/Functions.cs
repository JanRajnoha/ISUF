using ISUF.UI.App;
using System;
using System.Collections.Generic;
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

        public static T FindControl<T>(UIElement parent, Type targetType, string controlName) where T : FrameworkElement
        {
            if (controlName is null)
                throw new Base.Exceptions.ArgumentNullException(nameof(controlName));

            if (parent == null) return null;

            if (parent.GetType() == targetType && ((T)parent).Name == controlName)
                return (T)parent;

            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                UIElement child = (UIElement)VisualTreeHelper.GetChild(parent, i);

                if (child is ContentControl contentChild && contentChild.Content is UIElement innerContent)
                {
                    if (contentChild.Name == controlName)
                        return (T)child;

                    child = innerContent;
                }

                var innerControl = FindControl<T>(child, targetType, controlName);
                if (innerControl != null)
                {
                    return innerControl;
                }
            }

            return null;
        }

        public static IList<FrameworkElement> GetControlsByName(FrameworkElement parent, string controlName, bool partMatch = false)
        {
            var results = new List<FrameworkElement>();

            if (parent == null) return null;

            if ((!partMatch && parent.Name.Contains(controlName) && parent.Name.Length == controlName.Length) ||
                (partMatch && parent.Name.Contains(controlName)) || parent.Name.Length == controlName.Length)
                results.Add(parent);

            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                FrameworkElement child = (FrameworkElement)VisualTreeHelper.GetChild(parent, i);

                if (child is ContentControl contentChild && contentChild.Content is FrameworkElement innerContent)
                {
                    if ((!partMatch && parent.Name.Contains(controlName) && parent.Name.Length == controlName.Length) ||
                        ((partMatch && parent.Name.Contains(controlName)) || parent.Name.Length == controlName.Length))
                        results.Add(parent);

                    child = innerContent;
                }

                results.AddRange(GetControlsByName(child, controlName, partMatch));
            }

            return results;
        }

        public static void CreateViewModel(Type viewModelType, bool rewriteViewModel = false, params object[] viewModelArgs)
        {
            if (ApplicationBase.Current.VMLocator.GetViewModel(viewModelType) != null && !rewriteViewModel)
                return;

            object viewModel = Base.Classes.Functions.CreateInstance(viewModelType, viewModelArgs);
            ApplicationBase.Current.VMLocator.AddViewModel(viewModel, rewriteViewModel);
        }
    }
}
