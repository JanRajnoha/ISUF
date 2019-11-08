using ISUF.Base.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Converters
{
    /// <summary>
    /// Switch value based on parameter for SecodaryTile
    /// </summary>
    public class SecondaryTileExistConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool boolValue && parameter is string param)
            {
                switch (param.ToLower())
                {
                    case "icon":
                    case "symbol":
                        return boolValue ? new SymbolIcon(Symbol.UnPin) : new SymbolIcon(Symbol.Pin);

                    case "text":
                        return boolValue ? "Unpin from Start" : "Pin to Start";

                    default:
                        LogService.AddLogMessage("Parameter is wrong: " + param);
                        return "err";
                }
            }

            LogService.AddLogMessage($"SecondaryTileExistConverter: Value or parameter is wrong: Value: {value.ToString()}; Parameter: {parameter?.ToString()}");
            return "err";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
