using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Converters
{
    /// <summary>
    /// Check date and return it or if is null, return DateTime.Today
    /// </summary>
    public class DateToDateTimeOffsetConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is DateTime)
                return new DateTimeOffset((DateTime)value);

            return new DateTimeOffset(DateTime.Today);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is DateTimeOffset)
                return ((DateTimeOffset)value).DateTime;

            return DateTime.Today;
        }
    }
}
