using ISUF.Base.Attributes;
using ISUF.Base.Enum;
using ISUF.Base.Exceptions;
using ISUF.Base.Modules;
using ISUF.Base.Template;
using ISUF.UI.Classes;
using ISUF.UI.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Controls
{
    public class LinkedTableSingleSelectorControl : Grid
    {
        readonly PropertyAnalyze controlData;

        private int selectedLinkedId = -1;
        private TextBlock selectedIdLabel;

        public Type LinkedTableType { get; private set; }

        public LinkedTableSingleSelectorControl(string controlName, PropertyAnalyze controlData, LinkedTableAttribute linkedTableAttribute)
        {
            this.controlData = controlData;
            LinkedTableType = linkedTableAttribute.LinkedTableType;

            CreateUI(controlName, controlData);
        }

        private void CreateUI(string controlName, PropertyAnalyze controlData)
        {
            var customization = controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) as UIParamsAttribute;

            RowDefinition labelRow = new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Auto)
            };

            RowDefinition linkedTableControlsRow = new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Auto)
            };

            RowDefinitions.Add(labelRow);
            RowDefinitions.Add(linkedTableControlsRow);

            TextBlock headerLabel = new TextBlock()
            {
                Name = controlName + Constants.LABEL_CONTROL_IDENTIFIER,
                Text = customization.LabelDescription,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 0, 5)
            };
            SetRow(headerLabel, 0);
            Children.Add(headerLabel);

            ColumnDefinition linkedTableSelectorColumn = new ColumnDefinition()
            {
                Width = new GridLength(1, GridUnitType.Auto)
            };

            ColumnDefinition linkedTableCleanerColumn = new ColumnDefinition()
            {
                Width = new GridLength(1, GridUnitType.Auto)
            };

            ColumnDefinition linkedTableFreeColumn = new ColumnDefinition()
            {
                Width = new GridLength(1, GridUnitType.Auto)
            };

            RowDefinition linkedTableButtonsRow = new RowDefinition()
            {
                Height  = new GridLength(1, GridUnitType.Auto)
            };

            RowDefinition linkedTableInfoRow = new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Auto)
            };

            Grid linkedTableControlsRowGrid = new Grid();
            linkedTableControlsRowGrid.ColumnDefinitions.Add(linkedTableSelectorColumn);
            linkedTableControlsRowGrid.ColumnDefinitions.Add(linkedTableCleanerColumn);
            linkedTableControlsRowGrid.ColumnDefinitions.Add(linkedTableFreeColumn);

            linkedTableControlsRowGrid.RowDefinitions.Add(linkedTableButtonsRow);
            linkedTableControlsRowGrid.RowDefinitions.Add(linkedTableInfoRow);

            SetRow(linkedTableControlsRowGrid, 1);
            Children.Add(linkedTableControlsRowGrid);

            Button linkedTableRowSelector = new Button
            {
                Content = "Choose row",
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 5, 5)
            };

            linkedTableRowSelector.Click += LinkedTableRowSelector_Click;

            Button linkedTableRowCleaner = new Button
            {
                Content = "Clear link",
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5, 0, 5, 5)
            };
            SetColumn(linkedTableRowCleaner, 1);

            linkedTableRowCleaner.Click += LinkedTableRowCleaner_Click;

            TextBlock selectedIdTextLabel = new TextBlock()
            {
                Name = controlName + "InfoLabel",
                Text = "Selected ID: ",
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5, 5, 0, 0)
            };

            SetRow(selectedIdTextLabel, 1);

            selectedIdLabel = new TextBlock()
            {
                Name = controlName + "Label",
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5, 5, 0, 0)
            };

            SetColumn(selectedIdLabel, 1);
            SetRow(selectedIdLabel, 1);

            linkedTableControlsRowGrid.Children.Add(linkedTableRowSelector);
            linkedTableControlsRowGrid.Children.Add(linkedTableRowCleaner);
            linkedTableControlsRowGrid.Children.Add(selectedIdTextLabel);
            linkedTableControlsRowGrid.Children.Add(selectedIdLabel);
        }

        private void LinkedTableRowCleaner_Click(object sender, RoutedEventArgs e)
        {
            SetSelectedId(null);
        }

        public int GetSelectedId()
        {
            return selectedLinkedId;
        }

        public void SetSelectedId(AtomicItem selectedItem)
        {
            if (selectedItem != null)
            {
                selectedLinkedId = selectedItem.Id;

                if (selectedIdLabel != null)
                    selectedIdLabel.Text = selectedLinkedId.ToString();
            }
            else
                selectedLinkedId = -1;

            FormatSelectedIdText();
        }

        private void FormatSelectedIdText()
        {
            if (selectedIdLabel != null)
                selectedIdLabel.Text = selectedLinkedId != -1 ? selectedLinkedId.ToString() : "-";
        }

        public static UIElement CreateLinkedTableControl(string controlName, PropertyAnalyze controlData, PropertyType controlType, LinkedTableAttribute linkedTableAttribute)
        {
            if (controlData is null)
                throw new Base.Exceptions.ArgumentNullException(nameof(controlData));

            if (controlType != PropertyType.Int && controlType != PropertyType.Int32)
                throw new Base.Exceptions.ArgumentOutOfRangeException(nameof(controlData), "Type of linked table selector property must be integer.");

            if (!(controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) is UIParamsAttribute))
                throw new MissingRequiredAdditionalDataException("Linked table property require UIParams attribute for specificating design.");

            var control = new LinkedTableSingleSelectorControl(controlName, controlData, linkedTableAttribute)
            {
                Name = controlName + Constants.DATA_CONTROL_IDENTIFIER,
                Margin = new Thickness(10)
            };

            return control;
        }

        private void LinkedTableRowSelector_Click(object sender, RoutedEventArgs e)
        {
            LinkedTableSelector selector = new LinkedTableSelector(controlData);
            selector.ShowSelector(Selector_Closed);
        }

        private void Selector_Closed(MessageDialogResult result, List<object> selectedIds)
        {
            if (result == MessageDialogResult.Ok && selectedIds.Count >= 1)
                SetSelectedId(selectedIds[0] as AtomicItem);
        }
    }
}