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
    /// Return width for slave pane
    /// </summary>
    public class SlaveFrameWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null && value is bool && parameter != null && parameter is string)
            {

                if (!(bool)value)
                {
                    return new GridLength(0);
                }

                switch ((string)parameter)
                {
                    case "NarrowMinWidth":
                        return new GridLength(1, GridUnitType.Star);

                    case "NormalMinWidth":
                        return new GridLength(365);

                    case "WideMinWidth":
                        return new GridLength(500);

                    default:
                        return new GridLength(0);
                }
            }
            else
                return new GridLength(0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
