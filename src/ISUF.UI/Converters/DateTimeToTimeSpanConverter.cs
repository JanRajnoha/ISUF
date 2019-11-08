using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Converters
{
    /// <summary>
    /// Select from value (DateTime) TimeOfDay
    /// </summary>
    public class DateTimeToTimeSpanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return ((DateTime)value).TimeOfDay;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            var helper = DateTime.Now;
            TimeSpan UV = (TimeSpan)value;
            helper = new DateTime(helper.Year, helper.Month, helper.Day, UV.Hours, UV.Minutes, UV.Seconds);

            return helper;
        }
    }
}
