using ISUF.Base.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Converters
{
    /// <summary>
    /// Switch value based on parameter for SlavePane
    /// </summary>
    public class SlavePaneVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is GridLength lengthValue && parameter is string param)
            {
                switch (param.ToLower())
                {
                    case "symbol":
                    case "icon":
                        return lengthValue == new GridLength(0) ? new SymbolIcon(Symbol.ClosePane) : new SymbolIcon(Symbol.OpenPane);

                    case "text":
                        return lengthValue == new GridLength(0) ? "Open Pane" : "Close Pane";

                    default:
                        LogService.AddLogMessage("Parameter is wrong: " + param);
                        return "err";
                }
            }

            LogService.AddLogMessage($"SlavePaneVisibilityConverter: Value or parameter is wrong: Value: {value.ToString()}; Parameter: {parameter.ToString()}");
            return "err";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
