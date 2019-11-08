using ISUF.Base.Service;
using ISUF.Base.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Converters
{
    /// <summary>
    /// Converter return true, if selected TaskBaseItem is set to today day
    /// </summary>
    public class EnabledTodayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is TaskBaseItem tBItem)
            {
                return tBItem.NotifyDays.Contains(DateTime.Today.DayOfWeek) && tBItem.Start.Date <= DateTime.Today && (tBItem.End.Date >= DateTime.Today || tBItem.Neverend) && SettingsService.Instance.UseSlidableItems;
            }
            else
                return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
