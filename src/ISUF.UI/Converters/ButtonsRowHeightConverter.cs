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
    /// Convertor return 120, if is AddActivityComp in Add Activity mode, 60 when is in editing mode
    /// </summary>
    public class ButtonsRowHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            int FullSize = (Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily.Contains("Mobile") && SettingsService.Instance.UseBiggerButtons) ? 200 : 120;

            if (value != null)
                return (string)value == "Add" ? new GridLength(FullSize) : new GridLength(FullSize / 2);
            else
                return new GridLength(FullSize);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
