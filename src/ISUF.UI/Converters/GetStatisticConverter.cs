using ISUF.Base.Classes;
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
    /// Return statistics for selected task base item. Item is specified by parameter
    /// </summary>
    public class GetStatisticConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is TaskBaseItem tBItem && parameter is string param)
            {
                var Fce = new Functions();

                var AllDays = Fce.GetDaysCount(Fce.GetSpecificDays(tBItem.NotifyDays, Fce.GetNumberOfWeekDays(tBItem.Start, tBItem.End)));

                string tBItemProgress, tBItemCompleted;

                if (tBItem.Start <= DateTime.Today && tBItem.End >= DateTime.Today && !tBItem.Neverend)
                {
                    tBItemCompleted = (Fce.GetDaysCount(tBItem.NotifyDays, tBItem.Dates) * 100 / AllDays).ToString() + "%";
                    tBItemProgress = (Fce.GetDaysCount(Fce.GetSpecificDays(tBItem.NotifyDays, Fce.GetNumberOfWeekDays(tBItem.Start, DateTime.Today))) * 100 / AllDays).ToString() + "%";
                }
                else
                {
                    tBItemProgress = (string)new GetStatusConverter().Convert(tBItem, null, null, null);
                    tBItemCompleted = tBItemProgress;
                }

                tBItemCompleted = $"{param} completed: {tBItemCompleted}";
                tBItemProgress = $"\n{param} progress: {tBItemProgress}";

                return tBItemCompleted + tBItemProgress;
            }
            else
                return "Problem with getting statistic";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
