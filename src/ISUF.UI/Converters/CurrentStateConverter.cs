using ISUF.Base.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace ISUF.UI.Converters
{
    /// <summary>
    /// Converter return color for current state
    /// </summary>
    public class CurrentStateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is TaskBaseItem tBItem)
            {
                return tBItem.Start.Date > DateTime.Today ? new SolidColorBrush(Color.FromArgb(255, 0, 174, 255)) :
                        (tBItem.End.Date < DateTime.Today && !tBItem.Neverend) ? new SolidColorBrush(Color.FromArgb(255, 255, 162, 0)) :
                        tBItem.Dates.Contains(DateTime.Today) ? new SolidColorBrush(Color.FromArgb(123, 9, 201, 0)) : new SolidColorBrush(Color.FromArgb(0, 64, 64, 64));
            }
            else
                return new SolidColorBrush(Color.FromArgb(255, 255, 162, 0));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
