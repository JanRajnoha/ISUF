using ISUF.UI.Controls;
using System;
using System.Linq;
using Windows.UI.Xaml;
using System.Collections.Generic;
using System.Reflection;
using Windows.UI.Xaml.Controls;
using ISUF.Base.Template;
using ISUF.UI.App;
using ISUF.Storage.Modules;
using ISUF.Base.Attributes;
using System.Globalization;
using System.Threading;

namespace ISUF.UI.Design
{
    public class FormDataMiner
    {
        public static void FillValueIntoControl(FrameworkElement formControl, object item)
        {
            throw new Base.Exceptions.NotImplementedException("Not implemented yet.");
        }

        public static void FillValuesIntoForm(IList<FrameworkElement> formControls, object item, bool isDetailMode = false)
        {
            var itemProps = item.GetType().GetProperties();

            foreach (var formControl in formControls)
            {
                var formControlName = formControl.Name.Substring(0, formControl.Name.Length - Classes.Constants.DATA_CONTROL_IDENTIFIER.Length);
                var itemProp = itemProps.FirstOrDefault(x => x.Name == formControlName);

                if (itemProp == null)
                    throw new Base.Exceptions.ArgumentException("None of controls not match property name.");

                var value = itemProp.GetValue(item);

                if (isDetailMode)
                    value = ConvertValueToFormValue(itemProp, value);

                SetValueIntoControl(formControl, value);
            }
        }

        private static object ConvertValueToFormValue(PropertyInfo prop, object value)
        {
            if (prop.PropertyType == typeof(DateTime))
            {
                var customization = prop.GetCustomAttributes(true).ToList().FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) as UIParamsAttribute;
                DateTime dateTimeValue = (DateTime)value;

                if (customization == null)
                    throw new Base.Exceptions.MissingRequiredAdditionalDataException("DateTime missing UIParams attribute.");

                CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;

                switch (customization.DateTimeMode)
                {
                    case Base.Enum.DatePickerMode.Date:
                        return dateTimeValue.ToString("d", currentCulture);

                    case Base.Enum.DatePickerMode.Time:
                        return dateTimeValue.ToString("t", currentCulture);

                    case Base.Enum.DatePickerMode.DateAndTime:
                        return dateTimeValue.ToString("g", currentCulture);

                    default:
                        throw new Base.Exceptions.UnsuccessfulConversionException("DateTime conversion was unsuccessful.\n" +
                            $"Unsupported DateTIme mode: {customization.DateTimeMode.ToString()}");
                }
            }
            else
                return value;
        }

        private static void SetValueIntoControl(FrameworkElement formControl, object value)
        {
            if (formControl is TextBox textBoxControl)
                textBoxControl.Text = value == null ? "" : value.ToString();

            else if (formControl is TextBlock textBlockControl)
                textBlockControl.Text = value == null ? "" : value.ToString();

            else if (formControl is LinkedTableMultiSelectorControl multiSelectorControl)
                if (value is IList<int> || value == null)
                {
                    IList<int> intValues = value == null ? new List<int>() : (List<int>)value;

                    List<AtomicItem> selectedItems = new List<AtomicItem>();

                    var linkedTableType = multiSelectorControl.LinkedTableType;
                    var storageModule = ApplicationBase.Current.ModuleManager.GetModule(linkedTableType) as StorageModule;

                    foreach (var intValue in intValues)
                    {
                        var linkedTableItem = storageModule.GetItemById<AtomicItem>(intValue);

                        selectedItems.Add(linkedTableItem);
                    }

                    multiSelectorControl.SetSelectedIds(selectedItems);
                }
                else
                    throw new Base.Exceptions.NotSupportedException("Property value is not compatible with control.");

            else if (formControl is LinkedTableSingleSelectorControl singleSelectorControl)
                if (value is int intValue)
                {
                    var linkedTableType = singleSelectorControl.LinkedTableType;
                    var storageModule = ApplicationBase.Current.ModuleManager.GetModule(linkedTableType) as StorageModule;
                    var linkedTableItem = storageModule.GetItemById<AtomicItem>(intValue);

                    singleSelectorControl.SetSelectedId(linkedTableItem);
                }
                else
                    throw new Base.Exceptions.NotSupportedException("Property value is not compatible with control.");

            else if (formControl is CalendarDatePicker calendarControl)
                calendarControl.Date = value == null ? DateTime.Today : (DateTime)value;

            else if (formControl is TimePicker timePickerControl)
                if (value is DateTime || value == null)
                    timePickerControl.Time = value == null ? DateTime.Today.TimeOfDay : ((DateTime)value).TimeOfDay;
                else
                    throw new Base.Exceptions.NotSupportedException("Property value is not compatible with control.");

            else if (formControl is CheckBox checkBoxControl)
                if (value is bool boolValue)
                    checkBoxControl.IsChecked = boolValue;
                else
                    throw new Base.Exceptions.NotSupportedException("Property value is not compatible with control.");

            else
                throw new Base.Exceptions.NotSupportedException("Not supported type of control for setting value.");
        }

        public static T FillValueIntoProperty<T>(FrameworkElement formControl, T item) where T : BaseItem
        {
            throw new Base.Exceptions.NotImplementedException("Not implemented yet.");
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
            if (formControl is TextBox textBoxControl)
                return textBoxControl.Text;
            else if (formControl is LinkedTableMultiSelectorControl multiSelectorControl)
                return multiSelectorControl.GetSelectedIds();
            else if (formControl is LinkedTableSingleSelectorControl singleSelectorControl)
                return singleSelectorControl.GetSelectedId();
            else if (formControl is CalendarDatePicker calendarControl)
                return calendarControl.Date;
            else if (formControl is TimePicker timePickerControl)
                return timePickerControl.Time;
            else if (formControl is CheckBox checkBoxControl)
                return checkBoxControl.IsChecked;
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
