using ISUF.Base.Attributes;
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
            UIParamsAttribute customization;

            switch (contorlTypeName)
            {
                case "string":
                case "int":
                case "int32":
                case "double":
                case "char":
                    control = new TextBox()
                    {
                        Name = controlName,
                        Margin = new Thickness(10),
                        TextWrapping = TextWrapping.Wrap,
                        PlaceholderText = "Insert " + controlName
                    };

                    customization = controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) as UIParamsAttribute;
                    if (customization != null && customization.UseLongTextInput)
                        (control as TextBox).Height = 150;

                    break;

                case "boolean":
                    control = new CheckBox()
                    {
                        Content = controlName,
                        Margin = new Thickness(10)
                    };
                    break;

                case "datetime":

                    customization = controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) as UIParamsAttribute;
                    if (customization == null)
                        throw new MissingRequiredAdditionalDataException("Property DateTime require UIParams attribute for specificating design.");

                    control = new Grid()
                    {
                        Margin = new Thickness(10)
                    };

                    RowDefinition labelRow = new RowDefinition()
                    {
                        Height = new GridLength(1, GridUnitType.Auto)
                    };

                    RowDefinition dateTimeRow = new RowDefinition()
                    {
                        Height = new GridLength(1, GridUnitType.Auto)
                    };

                    (control as Grid).RowDefinitions.Add(labelRow);
                    (control as Grid).RowDefinitions.Add(dateTimeRow);

                    TextBlock label = new TextBlock()
                    {
                        Text = customization.LabelDescription,
                        VerticalAlignment = VerticalAlignment.Center,
                        Margin = new Thickness(0, 0, 0, 5)
                    };
                    Grid.SetRow(label, 0);
                    (control as Grid).Children.Add(label);

                    UIElement dateTimeControl;

                    switch (customization.DateTimeMode)
                    {
                        case Base.Enum.DatePickerMode.Date:
                            dateTimeControl = new CalendarDatePicker()
                            {
                                Date = DateTime.Today,
                                HorizontalAlignment = HorizontalAlignment.Stretch,
                                Margin = new Thickness(0, 5, 0, 0),
                                PlaceholderText = "Select a date"
                            };
                            break;

                        case Base.Enum.DatePickerMode.Time:
                            dateTimeControl = new TimePicker()
                            {
                                Time = DateTime.Now.TimeOfDay,
                                HorizontalAlignment = HorizontalAlignment.Stretch,
                                Margin = new Thickness(0, 5, 0, 0)
                            };
                            break;

                        case Base.Enum.DatePickerMode.DateAndTime:
                            throw new Base.Exceptions.NotSupportedException();

                        default:
                            throw new Base.Exceptions.NotSupportedException();
                    }

                    Grid.SetRow(dateTimeControl as FrameworkElement, 1);

                    (control as Grid).Children.Add(dateTimeControl);

                    break;

                case "notImplementedYet":
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
