using ISUF.Base.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace ISUF.UI.Converters
{
    /// <summary>
    /// Converter return selected value based on parameter, if task base item is completed
    /// </summary>
    public class CompletedTodayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is ObservableCollection<DateTime> dateCollection && parameter is string param)
                switch (param.ToLower())
                {
                    case "flyout":
                        return dateCollection.Contains(DateTime.Today) ? new SolidColorBrush(Color.FromArgb(187, 93, 93, 93)) : new SolidColorBrush(Color.FromArgb(0, 93, 93, 93));

                    case "symbol":
                    case "icon":
                        return dateCollection.Contains(DateTime.Today) ? Symbol.Clear : Symbol.Accept;

                    case "text":
                        return dateCollection.Contains(DateTime.Today) ? "Uncomplete" : "Complete";

                    case "slider":
                        return dateCollection.Contains(DateTime.Today) ? new SolidColorBrush(Color.FromArgb(96, 247, 27, 17)) : new SolidColorBrush(Color.FromArgb(97, 2, 199, 2));

                    default:
                        LogService.AddLogMessage("Parameter is wrong: " + param);
                        return "err";
                }

            LogService.AddLogMessage($"CompletedTodayConverter: Value or parameter is wrong: Value: {value.ToString()}; Parameter: {parameter.ToString()}");
            return "err";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
