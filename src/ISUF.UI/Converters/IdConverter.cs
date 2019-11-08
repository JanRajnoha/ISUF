using ISUF.Base.Service;
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
    /// Convert ID to selected value based on parameter
    /// </summary>
    public class IdConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is int intValue && parameter is string param)
            {
                switch (param.ToLower())
                {
                    case "visibility":
                        return intValue == -1 ? Visibility.Visible : Visibility.Collapsed;

                    case "text":
                        return intValue == -1 ? "Add" : "Edit";

                    default:
                        LogService.AddLogMessage("Parameter is wrong: " + param);
                        return "err";
                }
            }

            LogService.AddLogMessage($"IdConverter: Value or parameter is wrong: Value: {value.ToString()}; Parameter: {parameter.ToString()}");
            return "err";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
