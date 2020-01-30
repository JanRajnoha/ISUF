using ISUF.Base.Attributes;
using ISUF.Base.Enum;
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
    public static class ControlCreator
    {
        public static UIElement CreateEditableControl(KeyValuePair<string, PropertyAnalyze> controlAnalyze, ref UIElement previousControl)
        {
            string controlName = controlAnalyze.Key;
            PropertyAnalyze controlData = controlAnalyze.Value;
            PropertyType controlTypeName = controlData.PropertyType;
            UIElement control;
            UIParamsAttribute customization;

            if (controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(LinkedTableAttribute)) != null)
            {
                control =  CreateLinkedTableControl(controlName, controlData, controlTypeName);
            }
            else
                switch (controlTypeName)
                {
                    case PropertyType.String:
                    case PropertyType.Int:
                    case PropertyType.Int32:
                    case PropertyType.Double:
                    case PropertyType.Char:

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

                    case PropertyType.Boolean:
                        control = new CheckBox()
                        {
                            Content = controlName,
                            Margin = new Thickness(10)
                        };
                        break;

                    case PropertyType.DateTime:

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
                            case DatePickerMode.Date:
                                dateTimeControl = new CalendarDatePicker()
                                {
                                    Date = DateTime.Today,
                                    HorizontalAlignment = HorizontalAlignment.Stretch,
                                    Margin = new Thickness(0, 5, 0, 0),
                                    PlaceholderText = "Select a date"
                                };
                                break;

                            case DatePickerMode.Time:
                                dateTimeControl = new TimePicker()
                                {
                                    Time = DateTime.Now.TimeOfDay,
                                    HorizontalAlignment = HorizontalAlignment.Stretch,
                                    Margin = new Thickness(0, 5, 0, 0)
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
            UIParamsAttribute customization;

            if (controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(LinkedTableAttribute)) != null)
            {
                control = CreateLinkedTableControl(controlName, controlData, controlTypeName);
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

                        customization = controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) as UIParamsAttribute;
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

                        TextBlock label = new TextBlock()
                        {
                            Text = customization == null ? controlTypeName.ToString() : customization.LabelDescription,
                            VerticalAlignment = VerticalAlignment.Center,
                            Margin = new Thickness(0, 0, 0, 5)
                        };
                        Grid.SetRow(label, 0);
                        (control as Grid).Children.Add(label);

                        TextBlock data = new TextBlock()
                        {
                            //Text = controlData.,
                            VerticalAlignment = VerticalAlignment.Center,
                            Margin = new Thickness(0, 0, 0, 5)
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
                                    PlaceholderText = "Select a date"
                                };
                                break;

                            case DatePickerMode.Time:
                                dateTimeControl = new TimePicker()
                                {
                                    Time = DateTime.Now.TimeOfDay,
                                    HorizontalAlignment = HorizontalAlignment.Stretch,
                                    Margin = new Thickness(0, 5, 0, 0)
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

        public static UIElement CreateLinkedTableControl(string controlName, PropertyAnalyze controlData, PropertyType controlType)
        {
            if (controlData is null)
                throw new Base.Exceptions.ArgumentNullException(nameof(controlData));

            if (controlType != PropertyType.Int || controlType != PropertyType.Int32)
                throw new Base.Exceptions.ArgumentOutOfRangeException(nameof(controlData), "Type of linked table property must be integer.");

            if (!(controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) is UIParamsAttribute customization))
                throw new MissingRequiredAdditionalDataException("Linked table property require UIParams attribute for specificating design.");

            var control = new Grid()
            {
                Margin = new Thickness(10)
            };

            RowDefinition labelRow = new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Auto)
            };

            RowDefinition linkedTableControlsRow = new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Auto)
            };

            control.RowDefinitions.Add(labelRow);
            control.RowDefinitions.Add(linkedTableControlsRow);

            TextBlock label = new TextBlock()
            {
                Text = customization.LabelDescription,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 0, 5)
            };
            Grid.SetRow(label, 0);
            control.Children.Add(label);

            ColumnDefinition linkedTableSelectorColumn = new ColumnDefinition()
            {
                Width = new GridLength(1, GridUnitType.Auto)
            };

            ColumnDefinition linkedTableSelectedInfoColumn = new ColumnDefinition()
            {
                Width = new GridLength(1, GridUnitType.Auto)
            };

            Grid linkedTableControlsRowGrid = new Grid();
            linkedTableControlsRowGrid.ColumnDefinitions.Add(linkedTableSelectorColumn);
            linkedTableControlsRowGrid.ColumnDefinitions.Add(linkedTableSelectedInfoColumn);

            Grid.SetRow(linkedTableControlsRowGrid, 1);
            control.Children.Add(linkedTableControlsRowGrid);

            Button linkedTableRowSelector = new Button()
            {
                Content = "Choose row",
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 5, 0)
            };

            TextBlock linkedTableSelectedRowText = new TextBlock()
            {
                Name = controlName + "Label",
                Text = "Selected ID:",
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5, 0, 0, 0)
            };

            Grid.SetColumn(linkedTableSelectedRowText, 1);

            linkedTableControlsRowGrid.Children.Add(linkedTableRowSelector);
            linkedTableControlsRowGrid.Children.Add(linkedTableSelectedRowText);

            return control;
        }
    }
}
