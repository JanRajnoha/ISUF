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

            switch (contorlTypeName)
            {
                case "string":
                    TextBox textInput = new TextBox()
                    {
                        Name = controlName,
                        Margin = new Thickness(10),
                        TextWrapping = TextWrapping.Wrap,
                        PlaceholderText = "Insert " + controlName
                    };

                    RelativePanel.SetAlignLeftWithPanel(textInput, true);
                    RelativePanel.SetAlignRightWithPanel(textInput, true);
                    AddControlUnder(textInput, ref previousControl);

                    return textInput;

                case "char":
                case "int":
                case "int32":
                case "double":
                case "boolean":
                case "datetime":
                    Grid panel = new Grid()
                    {
                        Background = new SolidColorBrush(Colors.Red),
                        Margin = new Thickness(10)
                    };

                    RelativePanel.SetAlignLeftWithPanel(panel, true);
                    RelativePanel.SetAlignRightWithPanel(panel, true);

                    return panel;

                default:
                    throw new NotSupportedPropertyType();
            }
        }

        private static void AddControlUnder(UIElement control, ref UIElement upperControl)
        {
            if (upperControl != null)
                RelativePanel.SetBelow(control, upperControl);

            upperControl = control;
        }
    }
}
