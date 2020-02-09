using ISUF.Base.Attributes;
using ISUF.Base.Enum;
using ISUF.Base.Exceptions;
using ISUF.Base.Modules;
using ISUF.UI.Controls;
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
    public static class ControlCreator
    {
        private const string DATA_CONTROL_IDENTIFIER = "_data";

        public static UIElement CreateEditableControl(KeyValuePair<string, PropertyAnalyze> controlAnalyze, ref UIElement previousControl)
        {
            string controlName = controlAnalyze.Key;
            PropertyAnalyze controlData = controlAnalyze.Value;
            PropertyType controlTypeName = controlData.PropertyType;
            UIElement control;
            UIParamsAttribute customization = controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) as UIParamsAttribute;

            if (controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(LinkedTableAttribute)) != null)
            {
                control = LinkedTableSelectorControl.CreateLinkedTableSelectorControl(controlName, controlData, controlTypeName);
            }
            else
                switch (controlTypeName)
                {
                    case PropertyType.String:
                    case PropertyType.Int:
                    case PropertyType.Int32:
                    case PropertyType.Double:
                    case PropertyType.Char:

                        if (customization.ReadOnlyMode)
                        {
                            control = new Grid();

                            ColumnDefinition rowNameColumn = new ColumnDefinition()
                            {
                                Width = new GridLength(1, GridUnitType.Auto)
                            };

                            ColumnDefinition rowDataColumn = new ColumnDefinition()
                            {
                                Width = new GridLength(1, GridUnitType.Auto)
                            };

                            (control as Grid).ColumnDefinitions.Add(rowNameColumn);
                            (control as Grid).ColumnDefinitions.Add(rowDataColumn);

                            var nameLabel = new TextBlock()
                            {
                                Text = controlName + ":",
                                Margin = new Thickness(10),
                                TextWrapping = TextWrapping.Wrap
                            };

                            var dataLabel = new TextBlock()
                            {
                                Name = controlName + DATA_CONTROL_IDENTIFIER,
                                Margin = new Thickness(10),
                                TextWrapping = TextWrapping.Wrap
                            };
                            Grid.SetColumn(dataLabel, 1);

                            (control as Grid).Children.Add(nameLabel);
                            (control as Grid).Children.Add(dataLabel);
                        }
                        else
                        {
                            control = new TextBox()
                            {
                                Name = controlName + DATA_CONTROL_IDENTIFIER,
                                Margin = new Thickness(10),
                                TextWrapping = TextWrapping.Wrap,
                                PlaceholderText = "Insert " + controlName
                            };

                            if (customization != null && customization.UseLongTextInput)
                                (control as TextBox).Height = 150;
                        }

                        break;

                    case PropertyType.Boolean:
                        control = new CheckBox()
                        {
                            Content = controlName,
                            Margin = new Thickness(10),
                            Name = controlName + DATA_CONTROL_IDENTIFIER
                        };
                        break;

                    case PropertyType.DateTime:

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
                            Text = customization == null ? controlTypeName.ToString() : customization.LabelDescription,
                            VerticalAlignment = VerticalAlignment.Center,
                            Margin = new Thickness(0, 0, 0, 5)
                        };
                        Grid.SetRow(label, 0);
                        (control as Grid).Children.Add(label);

                        //if (customization.ReadOnlyMode)
                        //{
                        //    TextBox data = new TextBox()
                        //    {
                        //        Text = "",
                        //        VerticalAlignment = VerticalAlignment.Center,
                        //        Margin = new Thickness(0, 0, 0, 5),
                        //        Name = controlName + DATA_CONTROL_IDENTIFIER
                        //    };
                        //}
                        //else
                        //{
                        //    TextBlock data = new TextBlock()
                        //    {
                        //        Text = "",
                        //        VerticalAlignment = VerticalAlignment.Center,
                        //        Margin = new Thickness(0, 0, 0, 5),
                        //        Name = controlName + DATA_CONTROL_IDENTIFIER
                        //    };
                        //}

                        UIElement dateTimeControl;

                        switch (customization.DateTimeMode)
                        {
                            case DatePickerMode.Date:
                                dateTimeControl = new CalendarDatePicker()
                                {
                                    Date = DateTime.Today,
                                    HorizontalAlignment = HorizontalAlignment.Stretch,
                                    Margin = new Thickness(0, 5, 0, 0),
                                    PlaceholderText = "Select a date",
                                    Name = controlName + DATA_CONTROL_IDENTIFIER
                                };
                                break;

                            case DatePickerMode.Time:
                                dateTimeControl = new TimePicker()
                                {
                                    Time = DateTime.Now.TimeOfDay,
                                    HorizontalAlignment = HorizontalAlignment.Stretch,
                                    Margin = new Thickness(0, 5, 0, 0),
                                    Name = controlName + DATA_CONTROL_IDENTIFIER
                                };
                                break;

                            case DatePickerMode.DateAndTime:
                                throw new Base.Exceptions.NotSupportedException();

                            default:
                                throw new Base.Exceptions.NotSupportedException();
                        }

                        Grid.SetRow(dateTimeControl as FrameworkElement, 1);

                        (control as Grid).Children.Add(dateTimeControl);

                        break;

                    case PropertyType.notImplementedYet:
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

        internal static UIElement CreateDetailControl(KeyValuePair<string, PropertyAnalyze> controlAnalyze, ref UIElement previousControl)
        {
            string controlName = controlAnalyze.Key;
            PropertyAnalyze controlData = controlAnalyze.Value;
            PropertyType controlTypeName = controlData.PropertyType;
            UIElement control;
            UIParamsAttribute customization = controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) as UIParamsAttribute;

            if (controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(LinkedTableAttribute)) != null)
            {
                control = LinkedTableSelectorControl.CreateLinkedTableSelectorControl(controlName, controlData, controlTypeName);
            }
            else
                switch (controlTypeName)
                {
                    case PropertyType.String:
                    case PropertyType.Int:
                    case PropertyType.Int32:
                    case PropertyType.Double:
                    case PropertyType.Char:
                    case PropertyType.DateTime:

                        if (customization == null && controlTypeName == PropertyType.DateTime)
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

                        if (customization.UseLabelDescription)
                        {
                            TextBlock label = new TextBlock()
                            {
                                Text = customization == null ? controlTypeName.ToString() : customization.LabelDescription,
                                VerticalAlignment = VerticalAlignment.Center,
                                Margin = new Thickness(0, 0, 0, 5)
                            };
                            Grid.SetRow(label, 0);
                            (control as Grid).Children.Add(label);
                        }

                        TextBox data = new TextBox()
                        {
                            Text = "",
                            VerticalAlignment = VerticalAlignment.Center,
                            Margin = new Thickness(0, 0, 0, 5),
                            Name = controlName + DATA_CONTROL_IDENTIFIER
                        };

                        UIElement dateTimeControl;

                        switch (customization.DateTimeMode)
                        {
                            case DatePickerMode.Date:
                                dateTimeControl = new CalendarDatePicker()
                                {
                                    Date = DateTime.Today,
                                    HorizontalAlignment = HorizontalAlignment.Stretch,
                                    Margin = new Thickness(0, 5, 0, 0),
                                    PlaceholderText = "Select a date",
                                    Name = controlName + DATA_CONTROL_IDENTIFIER,
                                    IsEnabled = true
                                };
                                break;

                            case DatePickerMode.Time:
                                dateTimeControl = new TimePicker()
                                {
                                    Time = DateTime.Now.TimeOfDay,
                                    HorizontalAlignment = HorizontalAlignment.Stretch,
                                    Margin = new Thickness(0, 5, 0, 0),
                                    Name = controlName + DATA_CONTROL_IDENTIFIER,
                                    IsEnabled = true
                                };
                                break;

                            case DatePickerMode.DateAndTime:
                                throw new Base.Exceptions.NotSupportedException();

                            default:
                                throw new Base.Exceptions.NotSupportedException();
                        }

                        Grid.SetRow(dateTimeControl as FrameworkElement, 1);

                        (control as Grid).Children.Add(dateTimeControl);

                        break;

                    case PropertyType.notImplementedYet:
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
