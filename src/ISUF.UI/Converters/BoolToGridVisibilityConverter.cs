using ISUF.UI.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Converters
{
    /// <summary>
    /// Check value and return zero width if value is false. For true return current non zero width
    /// </summary>
    public class BoolToGridVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null && value is bool)
                if ((bool)value)
                {
                    double MinNormalWidth = (double)ApplicationBase.Current.Resources["NormalMinWidth"];
                    if (MinNormalWidth > ApplicationView.GetForCurrentView().VisibleBounds.Width)
                        return new GridLength(1, GridUnitType.Star);
                    else
                        return new GridLength(365);
                }
                else
                    return new GridLength(0);
            else
                return new GridLength(0);

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
