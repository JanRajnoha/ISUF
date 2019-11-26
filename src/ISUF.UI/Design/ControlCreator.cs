using ISUF.Base.Exceptions;
using ISUF.Base.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ISUF.UI.Design
{
    public class ControlCreator
    {
        public static UIElement CreateControl(KeyValuePair<string, PropertyAnalyze> controlAnalyze, ref UIElement previousControl)
        {
            string controlName = controlAnalyze.Key;
            PropertyAnalyze controlData = controlAnalyze.Value;
            string contorlTypeName = controlData.PropertyType.Name.ToLower();
            UIElement control;

            switch (contorlTypeName)
            {
                case "string":
                    control = new TextBox()
                    {
                        Name = controlName,
                        Margin = new Thickness(10),
                        TextWrapping = TextWrapping.Wrap,
                        PlaceholderText = "Insert " + controlName
                    };
                    break;

                case "char":
                case "int":
                case "int32":
                case "double":
                case "boolean":
                case "datetime":
                    control = new Grid()
                    {
                        Background = new SolidColorBrush(Colors.Red),
                        Margin = new Thickness(10),
                        Height = 25
                    };
                    break;

                default:
                    throw new NotSupportedPropertyType();
            }

            RelativePanel.SetAlignLeftWithPanel(control, true);
            RelativePanel.SetAlignRightWithPanel(control, true);

            AddControlUnder(control, ref previousControl);

            return control;
        }

        private static void AddControlUnder(UIElement control, ref UIElement upperControl)
        {
            if (upperControl != null)
                RelativePanel.SetBelow(control, upperControl);

            upperControl = control;
        }
    }
}
