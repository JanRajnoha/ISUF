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
    /// <summary>
    /// Data miner from form ui objects
    /// </summary>
    public class FormDataMiner
    {
        /// <summary>
        /// Fill value into selected form control
        /// </summary>
        /// <param name="formControl">Selected form control</param>
        /// <param name="item">Item to be filled into form control</param>
        public static void FillValueIntoControl(FrameworkElement formControl, object item)
        {
            throw new Base.Exceptions.NotImplementedException("Not implemented yet.");
        }

        /// <summary>
        /// Fill values into form from model
        /// </summary>
        /// <param name="formControls">List of form controls</param>
        /// <param name="item">Model</param>
        /// <param name="isDetailMode">Value is filled into read only form control</param>
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

                SetValueIntoControl(formControl, value, itemProp);
            }
        }

        /// <summary>
        /// Convert value to value showed in form
        /// </summary>
        /// <param name="prop">Info of property</param>
        /// <param name="value">Value to be converted</param>
        /// <returns>Converted value</returns>
        private static object ConvertValueToFormValue(PropertyInfo prop, object value)
        {
            var linkedTableAttribute = prop.GetCustomAttributes(true).ToList().FirstOrDefault(x => x.GetType() == typeof(LinkedTableAttribute)) as LinkedTableAttribute;

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
            else if (linkedTableAttribute != null)
            {
                switch (linkedTableAttribute.LinkedTableRelation)
                {
                    case Base.Enum.LinkedTableRelation.One:

                        var intValue = (int)value;
                        if (intValue == -1)
                            return "-";

                        MethodInfo method = typeof(StorageModule).GetMethod("GetItemById");

                        StorageModule linkedModule = ApplicationBase.Current.ModuleManager.GetModule(linkedTableAttribute.LinkedTableType) as StorageModule;
                        MethodInfo genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);

                        var linkedTableItem = Convert.ChangeType(genericMethod.Invoke(linkedModule, new object[] { intValue }), genericMethod.ReturnType) as AtomicItem;

                        return linkedTableItem.ToString();

                    case Base.Enum.LinkedTableRelation.Many:

                        var intValues = (List<int>)value;
                        if (intValues == null || (intValues != null && intValues.Count == 0))
                            return new List<string> { "-" };

                        method = typeof(StorageModule).GetMethod("GetItemById");

                        linkedModule = ApplicationBase.Current.ModuleManager.GetModule(linkedTableAttribute.LinkedTableType) as StorageModule;
                        genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);

                        List<AtomicItem> selectedItems = new List<AtomicItem>();
                        foreach (var selectedItemValue in intValues)
                        {
                            var selectedLinkedTableItem = Convert.ChangeType(genericMethod.Invoke(linkedModule, new object[] { selectedItemValue }), genericMethod.ReturnType) as AtomicItem;

                            selectedItems.Add(selectedLinkedTableItem);
                        }

                        return selectedItems;

                    default:
                        throw new Base.Exceptions.NotSupportedException("Unsupported Linked table relation.");
                }
            }
            else
                return value;
        }

        /// <summary>
        /// Fill value into form control
        /// </summary>
        /// <param name="formControl">Form control</param>
        /// <param name="value">Value to be filled</param>
        /// <param name="itemProp">Info of property</param>
        private static void SetValueIntoControl(FrameworkElement formControl, object value, PropertyInfo itemProp)
        {
            if (formControl is TextBox textBoxControl)
                textBoxControl.Text = value == null ? "" : value.ToString();

            else if (formControl is TextBlock textBlockControl)
                textBlockControl.Text = value == null ? "" : value.ToString();

            else if (formControl is ListView selectedLinkedTableItems)
                selectedLinkedTableItems.ItemsSource = value;

            else if (formControl is LinkedTableMultiSelectorControl multiSelectorControl)
                if (value is IList<int> || value == null)
                {
                    IList<int> intValues = value == null ? new List<int>() : (List<int>)value;

                    List<AtomicItem> selectedItems = new List<AtomicItem>();

                    var linkedTableType = multiSelectorControl.LinkedTableType;
                    var linkedModule = ApplicationBase.Current.ModuleManager.GetModule(linkedTableType) as StorageModule;
                    MethodInfo method = typeof(StorageModule).GetMethod("GetItemById");
                    MethodInfo genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);

                    foreach (var intValue in intValues)
                    {
                        var linkedTableItem = Convert.ChangeType(genericMethod.Invoke(linkedModule, new object[] { intValue }), genericMethod.ReturnType) as AtomicItem;

                        selectedItems.Add(linkedTableItem);
                    }

                    multiSelectorControl.SetSelectedIds(selectedItems);
                }
                else
                    throw new Base.Exceptions.NotSupportedException("Property value is not compatible with control.");

            else if (formControl is LinkedTableSingleSelectorControl singleSelectorControl)
                if (value is int intValue)
                {
                    MethodInfo method = typeof(StorageModule).GetMethod("GetItemById");

                    var linkedTableType = singleSelectorControl.LinkedTableType;
                    var linkedModule = ApplicationBase.Current.ModuleManager.GetModule(linkedTableType) as StorageModule;
                    MethodInfo genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);

                    var linkedTableItem = Convert.ChangeType(genericMethod.Invoke(linkedModule, new object[] { intValue }), genericMethod.ReturnType) as AtomicItem;

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

        /// <summary>
        /// Fill value from form control into property
        /// </summary>
        /// <typeparam name="T">Type of item</typeparam>
        /// <param name="formControl">Form control</param>
        /// <param name="item">Model</param>
        /// <returns>Updated item</returns>
        public static T FillValueIntoProperty<T>(FrameworkElement formControl, T item) where T : BaseItem
        {
            throw new Base.Exceptions.NotImplementedException("Not implemented yet.");
        }

        /// <summary>
        /// Fill values from form controls into property
        /// </summary>
        /// <typeparam name="T">Type of item</typeparam>
        /// <param name="formControls">List of form control</param>
        /// <param name="item">Model</param>
        /// <returns>Updated item</returns>
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

        /// <summary>
        /// Get value from form control
        /// </summary>
        /// <param name="formControl">Form control</param>
        /// <returns>Value from form control</returns>
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

        /// <summary>
        /// Convert value from form control into item value
        /// </summary>
        /// <param name="value">Value from form</param>
        /// <param name="prop">Info of property</param>
        /// <returns>Converted value</returns>
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

        /// <summary>
        /// Get list of form controls
        /// </summary>
        /// <param name="form">Form</param>
        /// <returns>Lis of form controls</returns>
        public static IList<FrameworkElement> GetControlsFromForm(Control form)
        {
            return Classes.Functions.GetControlsByName(form, Classes.Constants.DATA_CONTROL_IDENTIFIER, true);
        }
    }
}
