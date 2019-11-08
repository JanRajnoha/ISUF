using ISUF.Base.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Converters
{

    /// <summary>
    /// Converter return red color if task base item is completed
    /// </summary>
    public class EndTaskBaseItemColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is TaskBaseItem tBItem)
            {
                if (tBItem.Neverend)
                    return Color.FromArgb(0, 247, 17, 17);
                else
                    return tBItem.End < DateTime.Today ? Color.FromArgb(96, 247, 17, 17) : Color.FromArgb(0, 247, 17, 17);
            }
            else
                return Color.FromArgb(96, 247, 17, 17);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
