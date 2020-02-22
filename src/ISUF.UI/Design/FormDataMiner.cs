using ISUF.UI.Controls;
using System;
using System.Linq;
using Windows.UI.Xaml;
using System.Collections.Generic;
using System.Reflection;
using Windows.UI.Xaml.Controls;
using ISUF.Base.Template;

namespace ISUF.UI.Design
{
    public class FormDataMiner
    {
        public static void FillValuesIntoForm(IList<FrameworkElement> formControls, object item)
        {
            var itemProps = item.GetType().GetProperties();

            foreach (var formControl in formControls)
            {
                var formControlName = formControl.Name.Substring(0, formControl.Name.Length - Classes.Constants.DATA_CONTROL_IDENTIFIER.Length);
                var itemProp = itemProps.FirstOrDefault(x => x.Name == formControlName);

                if (itemProp == null)
                    throw new Base.Exceptions.ArgumentException("None of controls not match property name.");

                var value = itemProp.GetValue(item);

                if (value != null)
                    GetValueIntoControl(formControl, value);
            }
        }

        private static void GetValueIntoControl(FrameworkElement formControl, object value)
        {
            if (formControl.GetType() == typeof(TextBox))
                (formControl as TextBox).Text = value.ToString();

            else if (formControl.GetType() == typeof(TextBlock))
                (formControl as TextBlock).Text = value.ToString();

            else if (formControl.GetType() == typeof(LinkedTablePresenterControl))
                if (value is IList<int> intValues)
                    (formControl as LinkedTablePresenterControl).SetSelectedIds(intValues);
                else
                    throw new Base.Exceptions.NotSupportedException("Property value is not compatible with control.");

            else if (formControl.GetType() == typeof(LinkedTableSelectorControl))
                if (value is int intValue)
                    (formControl as LinkedTableSelectorControl).SetSelectedId(intValue);
            else
                throw new Base.Exceptions.NotSupportedException("Property value is not compatible with control.");

            else if (formControl.GetType() == typeof(CalendarDatePicker))
                (formControl as CalendarDatePicker).Date = (DateTime)value;

            else if (formControl.GetType() == typeof(TimePicker))
                if (value is DateTime dateTimeValue)
                    (formControl as TimePicker).Time = dateTimeValue.TimeOfDay;
                else
                    throw new Base.Exceptions.NotSupportedException("Property value is not compatible with control.");

            else if (formControl.GetType() == typeof(CheckBox))
                if (value is bool boolValue)
                    (formControl as CheckBox).IsChecked = boolValue;
                else
                    throw new Base.Exceptions.NotSupportedException("Property value is not compatible with control.");

            else
                throw new Base.Exceptions.NotSupportedException("Not supported type of control for setting value.");
        }

        public static T FillValuesIntoProperty<T>(IList<FrameworkElement> formControls, T item) where T : BaseItem
        {
            var itemProps = typeof(T).GetProperties();

            foreach (var formControl in formControls)
            {
                var formControlName = formControl.Name.Substring(0, formControl.Name.Length - Classes.Constants.DATA_CONTROL_IDENTIFIER.Length);
                var itemProp = itemProps.FirstOrDefault(x => x.Name == formControlName);

                if (itemProp == null)
                    throw new Base.Exceptions.ArgumentException("None of controls not match property name.");

                if (formControl.GetType() == typeof(TextBlock))
                    continue;

                object value = GetValueFromControl(formControl);

                if (value.GetType() != itemProp.PropertyType)
                    value = ConvertValueToPropValue(value, itemProp);

                itemProp.SetValue(item, value);
            }

            return item;
        }

        private static object GetValueFromControl(FrameworkElement formControl)
        {
            if (formControl.GetType() == typeof(TextBox))
                return (formControl as TextBox).Text;
            else if (formControl.GetType() == typeof(LinkedTablePresenterControl))
                return (formControl as LinkedTablePresenterControl).GetSelectedIds();
            else if (formControl.GetType() == typeof(LinkedTableSelectorControl))
                return (formControl as LinkedTableSelectorControl).GetSelectedId();
            else if (formControl.GetType() == typeof(CalendarDatePicker))
                return (formControl as CalendarDatePicker).Date;
            else if (formControl.GetType() == typeof(TimePicker))
                return (formControl as TimePicker).Time;
            else if (formControl.GetType() == typeof(CheckBox))
                return (formControl as CheckBox).IsChecked;
            else
                throw new Base.Exceptions.NotSupportedException("Not supported type of control for getting value.");
        }

        private static object ConvertValueToPropValue(object value, PropertyInfo prop)
        {
            object convertedValue;
            bool conversionResult = true;

            if (value.GetType() == typeof(string))
                if (prop.PropertyType == typeof(int))
                {
                    conversionResult = int.TryParse(value as string, out int convertedNumber);
                    convertedValue = convertedNumber;
                }
                else if (prop.PropertyType == typeof(byte))
                {
                    conversionResult = byte.TryParse(value as string, out byte convertedNumber);
                    convertedValue = convertedNumber;
                }
                else if (prop.PropertyType == typeof(double))
                {
                    conversionResult = double.TryParse(value as string, out double convertedNumber);
                    convertedValue = convertedNumber;
                }
                else if (prop.PropertyType == typeof(decimal))
                {
                    conversionResult = decimal.TryParse(value as string, out decimal convertedNumber);
                    convertedValue = convertedNumber;
                }
                else if (prop.PropertyType == typeof(float))
                {
                    conversionResult = float.TryParse(value as string, out float convertedNumber);
                    convertedValue = convertedNumber;
                }
                else if (prop.PropertyType == typeof(char))
                    return value;
                else
                    throw new Base.Exceptions.NotSupportedException("Not supported type conversion between control and property.\n" +
                    $"Value type: {value.GetType()}\n\n" +
                    $"Target type: {prop.PropertyType}");
            else if (value.GetType() == typeof(TimeSpan))
                convertedValue = DateTime.Today + (TimeSpan)value;
            else if (value.GetType() == typeof(DateTimeOffset))
                convertedValue = ((DateTimeOffset)value).DateTime;
            else
                throw new Base.Exceptions.NotSupportedException("Not supported type conversion between control and property.\n" +
                    $"Value type: {value.GetType()}\n" +
                    $"Target type: {prop.PropertyType}");

            if (!conversionResult)
                throw new Base.Exceptions.UnsuccessfulConversionException("Conversion was unsuccessful.\n" +
                    $"Value type: {value.GetType().ToString()}\n" +
                    $"Target type: {prop.PropertyType.Name}");

            return convertedValue;
        }

        public static IList<FrameworkElement> GetControlsFromForm(Control form)
        {
            return Classes.Functions.GetControlsByName(form, Classes.Constants.DATA_CONTROL_IDENTIFIER, true);
        }
    }
}
