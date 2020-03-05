using ISUF.Base.Attributes;
using ISUF.Base.Enum;
using ISUF.Base.Exceptions;
using ISUF.Base.Modules;
using ISUF.UI.Classes;
using ISUF.UI.Controls;
using ISUF.UI.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ISUF.UI.Design
{
    public static class ControlCreator
    {
        public static UIElement CreateEditableControl(KeyValuePair<string, PropertyAnalyze> controlAnalyze, ref UIElement previousControl, UIModule uiModule)
        {
            string controlName = controlAnalyze.Key;
            PropertyAnalyze controlData = controlAnalyze.Value;
            PropertyType controlTypeName = controlData.PropertyType;
            UIElement control;
            UIParamsAttribute customization = controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) as UIParamsAttribute;

            var linkedTableAttribute = controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(LinkedTableAttribute)) as LinkedTableAttribute;
            if (linkedTableAttribute != null)
            {
                switch (linkedTableAttribute.LinkedTableRelation)
                {
                    case LinkedTableRelation.One:
                        control = LinkedTableSingleSelectorControl.CreateLinkedTableControl(controlName, controlData, controlTypeName, linkedTableAttribute);
                        break;

                    case LinkedTableRelation.Many:
                        control = LinkedTableMultiSelectorControl.CreateLinkedTableControl(controlName, controlData, controlTypeName, linkedTableAttribute);
                        break;

                    default:
                        throw new NotSupportedPropertyTypeException("Not supported LinkedTableRelation.");
                }

            }
            else
                switch (controlTypeName)
                {
                    case PropertyType.String:
                    case PropertyType.Int:
                    case PropertyType.Int32:
                    case PropertyType.Double:
                    case PropertyType.Char:
                    case PropertyType.Decimal:
                    case PropertyType.Float:

                        control = new TextBox()
                        {
                            Name = controlName + Constants.DATA_CONTROL_IDENTIFIER,
                            Margin = new Thickness(10),
                            TextWrapping = TextWrapping.Wrap,
                            PlaceholderText = "Insert " + controlName
                        };

                        if (controlTypeName == PropertyType.Char)
                            (control as TextBox).MaxLength = 1;

                        if (customization != null && customization.UseLongTextInput)
                            (control as TextBox).Height = 150;
                        break;

                    case PropertyType.Boolean:
                        control = new CheckBox()
                        {
                            Content = controlName,
                            Margin = new Thickness(10),
                            Name = controlName + Constants.DATA_CONTROL_IDENTIFIER
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
                            Name = controlName + Constants.LABEL_CONTROL_IDENTIFIER,
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
                                    Name = controlName + Constants.DATA_CONTROL_IDENTIFIER
                                };
                                break;

                            case DatePickerMode.Time:
                                dateTimeControl = new TimePicker()
                                {
                                    Time = DateTime.Now.TimeOfDay,
                                    HorizontalAlignment = HorizontalAlignment.Stretch,
                                    Margin = new Thickness(0, 5, 0, 0),
                                    Name = controlName + Constants.DATA_CONTROL_IDENTIFIER
                                };
                                break;

                            case DatePickerMode.DateAndTime:
                                throw new Base.Exceptions.NotSupportedException("DateTime combination is not supported.");

                            default:
                                throw new Base.Exceptions.NotSupportedException("Not supported DatePickerMode.");
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
                        throw new NotSupportedPropertyTypeException("Not supported PropertyType.");
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

            switch (controlTypeName)
            {
                case PropertyType.String:
                case PropertyType.Int:
                case PropertyType.Int32:
                case PropertyType.Double:
                case PropertyType.Char:
                case PropertyType.DateTime:
                case PropertyType.Boolean:

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

                    ColumnDefinition labelColumn = new ColumnDefinition()
                    {
                        Width = new GridLength(1, GridUnitType.Auto)
                    };

                    ColumnDefinition dataColumn = new ColumnDefinition()
                    {
                        Width = new GridLength(1, GridUnitType.Auto)
                    };

                    (control as Grid).ColumnDefinitions.Add(labelColumn);
                    (control as Grid).ColumnDefinitions.Add(dataColumn);

                    TextBlock label = new TextBlock()
                    {
                        VerticalAlignment = VerticalAlignment.Bottom,
                        FontWeight = FontWeights.Bold,
                        Margin = new Thickness(0, 0, 5, 0)
                    };

                    if (customization.UseLabelDescription)
                        label.Text = customization.LabelDescription ?? "";
                    else
                        label.Text = controlData.PropertyName;

                    Grid.SetRow(label, 0);
                    (control as Grid).Children.Add(label);

                    //if (controlTypeName == PropertyType.DateTime)
                    //{
                    //    UIElement dateTimeControl;

                    //    switch (customization.DateTimeMode)
                    //    {
                    //        case DatePickerMode.Date:
                    //            dateTimeControl = new CalendarDatePicker()
                    //            {
                    //                Date = DateTime.Today,
                    //                HorizontalAlignment = HorizontalAlignment.Stretch,
                    //                Margin = new Thickness(0, 5, 0, 0),
                    //                PlaceholderText = "Select a date",
                    //                Name = controlName + Constants.DATA_CONTROL_IDENTIFIER,
                    //                IsEnabled = false
                    //            };
                    //            break;

                    //        case DatePickerMode.Time:
                    //            dateTimeControl = new TimePicker()
                    //            {
                    //                Time = DateTime.Now.TimeOfDay,
                    //                HorizontalAlignment = HorizontalAlignment.Stretch,
                    //                Margin = new Thickness(0, 5, 0, 0),
                    //                Name = controlName + Constants.DATA_CONTROL_IDENTIFIER,
                    //                IsEnabled = false
                    //            };
                    //            break;

                    //        case DatePickerMode.DateAndTime:
                    //            throw new Base.Exceptions.NotSupportedException("DateAndTime is not supported.");

                    //        default:
                    //            throw new Base.Exceptions.NotSupportedException("Not suported DatePickerMode.");
                    //    }

                    //    Grid.SetRow(dateTimeControl as FrameworkElement, 1);

                    //    (control as Grid).Children.Add(dateTimeControl);
                        TextBlock data = new TextBlock()
                        {
                            Text = "",
                            VerticalAlignment = VerticalAlignment.Bottom,
                            Margin = new Thickness(0, 5, 0, 0),
                            Name = controlName + Constants.DATA_CONTROL_IDENTIFIER
                        };
                        (control as Grid).Children.Add(data);

                        if (customization.ShowDetailOnOneLine)
                        {
                            data.Margin = new Thickness(5, 5, 0, 0);
                            Grid.SetColumn(data, 1);
                        }
                        else
                            Grid.SetRow(data, 1);

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
                    throw new NotSupportedPropertyTypeException("Not supported PropertyType.");
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
