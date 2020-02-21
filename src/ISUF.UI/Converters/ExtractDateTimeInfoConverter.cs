using ISUF.Base.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.UserProfile;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Converters
{
    /// <summary>
    /// Converter return date or time from DateTime type based on parameter
    /// </summary>
    public class ExtractDateTimeInfoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is DateTime dateTime && parameter is string param)
            {
                try
                {
                    switch (param.ToLower())
                    {
                        case "date":
                            return dateTime.ToString("d", new CultureInfo(GlobalizationPreferences.Languages[0].ToString()));

                        case "time":
                            return dateTime.ToString("t", new CultureInfo(GlobalizationPreferences.Languages[0].ToString()));

                        default:
                            LogService.AddLogMessage("Parameter is wrong: " + param);
                            return "err";
                    }

                }
                catch (Exception e)
                {
                    LogService.AddLogMessage($"ExtractDateTimeInfoConverter: {e.Message}");
                    return (DateTime)value;
                }
            }

            LogService.AddLogMessage($"ExtractDateTimeInfoConverter: Value or parameter is wrong: Value: {value.ToString()}; Parameter: {parameter.ToString()}");
            return "err";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
