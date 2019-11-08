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
    /// For theme selector
    /// </summary>
    public class EnumToBooleanConverter : IValueConverter
    {
        public Type EnumType { get; set; }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (parameter is string enumString)
            {
                if (SettingsService.Instance.UseSystemAppTheme)
                    return enumString == "System";
                else
                    if (enumString == "System")
                    return false;

                if (enumString == "System")
                    return SettingsService.Instance.UseSystemAppTheme;

                if (!Enum.IsDefined(EnumType, value))
                {
                    throw new ArgumentException("value must be an Enum!");
                }

                var enumValue = System.Enum.Parse(EnumType, enumString);

                return enumValue.Equals(value);
            }

            throw new ArgumentException("parameter must be an Enum name!");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (parameter is string enumString)
            {
                SettingsService.Instance.UseSystemAppTheme = enumString == "System";

                return Enum.Parse(EnumType, enumString);
            }

            throw new ArgumentException("parameter must be an Enum name!");
        }
    }
}
