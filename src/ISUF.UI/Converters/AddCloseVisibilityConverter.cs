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
    /// Convertor return *, if Add Button contnet is Add
    /// </summary>
    public class AddCloseVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null && value is Visibility)
                return (Visibility)value == Visibility.Visible ? new GridLength(120) : new GridLength(60);
            else
                return new GridLength(120);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
