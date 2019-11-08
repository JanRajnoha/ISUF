using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Converters
{
    /// <summary>
    /// Invert Visibility value
    /// </summary>
    public class InvertVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is Visibility)
                return (Visibility)value == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is Visibility)
                return (Visibility)value == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;

            return value;
        }
    }

}
