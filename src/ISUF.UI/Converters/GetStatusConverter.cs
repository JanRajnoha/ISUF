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
    /// Converter return current status of task base item
    /// </summary>
    public class GetStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is TaskBaseItem tBItem && parameter is string itemName)
            {
                return tBItem.Start > DateTime.Today ? "Not started" :
                        tBItem.Neverend ? "Neverending " + itemName :
                        tBItem.End < DateTime.Today ? "Ended" : "In progress";
            }
            else
                return "Problem with getting status";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
