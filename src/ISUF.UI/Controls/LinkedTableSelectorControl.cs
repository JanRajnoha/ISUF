using ISUF.Base.Attributes;
using ISUF.Base.Enum;
using ISUF.Base.Exceptions;
using ISUF.Base.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Controls
{
    public class LinkedTableSelectorControl : Grid
    {
        private int selectedLinkedID;

        public LinkedTableSelectorControl()
        {

        }

        public int GetSelectedId()
        {
            return selectedLinkedID;
        }

        public static UIElement CreateLinkedTableSelectorControl(string controlName, PropertyAnalyze controlData, PropertyType controlType)
        {
            if (controlData is null)
                throw new Base.Exceptions.ArgumentNullException(nameof(controlData));

            if (controlType != PropertyType.Int && controlType != PropertyType.Int32)
                throw new Base.Exceptions.ArgumentOutOfRangeException(nameof(controlData), "Type of linked table selector property must be integer.");

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
            SetRow(label, 0);
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

            SetRow(linkedTableControlsRowGrid, 1);
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

            SetColumn(linkedTableSelectedRowText, 1);

            linkedTableControlsRowGrid.Children.Add(linkedTableRowSelector);
            linkedTableControlsRowGrid.Children.Add(linkedTableSelectedRowText);

            return control;
        }
    }
}
