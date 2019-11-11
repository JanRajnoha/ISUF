using ISUF.Base.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Converters
{
    /// <summary>
    /// Create shortcut from value and parameter
    /// Language is used as parameter for normal or reverse concatenation
    /// </summary>
    public class StringConcatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is string text && parameter is string param)
            {
                switch (language.ToLower())
                {
                    case "reverse":
                        return param + " " + text;

                    case "normal":
                    default:
                        return text + " " + param;
                }
            }

            LogService.AddLogMessage($"StringConcatConverter: Value or parameter is wrong: Value: {value.ToString()}; Parameter: {language.ToString()}");
            return "err";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
