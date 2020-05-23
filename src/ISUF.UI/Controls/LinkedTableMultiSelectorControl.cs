using ISUF.Base.Attributes;
using ISUF.Base.Enum;
using ISUF.Base.Exceptions;
using ISUF.Base.Modules;
using ISUF.Base.Template;
using ISUF.Interface.UI;
using ISUF.UI.Classes;
using ISUF.UI.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ISUF.UI.Controls
{
    /// <summary>
    /// Linked table selector for multiple values
    /// </summary>
    public class LinkedTableMultiSelectorControl : Grid
    {
        readonly PropertyAnalyze controlData;

        private ListBox linkedTableSelectedIds;

        public Type LinkedTableType { get; private set; }

        /// <summary>
        /// Init Linked table selector for multi values
        /// </summary>
        /// <param name="controlName">Control name</param>
        /// <param name="controlData">Control data</param>
        /// <param name="linkedTableAttribute">Attributes of property</param>
        public LinkedTableMultiSelectorControl(string controlName, PropertyAnalyze controlData, LinkedTableAttribute linkedTableAttribute)
        {
            this.controlData = controlData;
            LinkedTableType = linkedTableAttribute.LinkedTableType;

            CreateUI(controlName, controlData);
        }

        /// <summary>
        /// Create UI of selector
        /// </summary>
        /// <param name="controlName">Control name</param>
        /// <param name="controlData">Control data</param>
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

            RowDefinition linkedTablePresenterRow = new RowDefinition()
            {
                Height = new GridLength(250, GridUnitType.Pixel)
            };

            RowDefinitions.Add(labelRow);
            RowDefinitions.Add(linkedTableControlsRow);
            RowDefinitions.Add(linkedTablePresenterRow);

            TextBlock label = new TextBlock()
            {
                Name = controlName + Constants.LABEL_CONTROL_IDENTIFIER,
                Text = customization.LabelDescription,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 0, 5)
            };
            SetRow(label, 0);
            Children.Add(label);

            ColumnDefinition linkedTablePresenterColumn = new ColumnDefinition()
            {
                Width = new GridLength(1, GridUnitType.Auto)
            };

            ColumnDefinition linkedTablePresenterInfoColumn = new ColumnDefinition()
            {
                Width = new GridLength(1, GridUnitType.Auto)
            };

            Grid linkedTableControlsRowGrid = new Grid();
            linkedTableControlsRowGrid.ColumnDefinitions.Add(linkedTablePresenterColumn);
            linkedTableControlsRowGrid.ColumnDefinitions.Add(linkedTablePresenterInfoColumn);

            SetRow(linkedTableControlsRowGrid, 1);
            Children.Add(linkedTableControlsRowGrid);

            Button linkedTableRowAdder = new Button()
            {
                Content = "Add row",
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 5, 0)
            };

            linkedTableRowAdder.Click += LinkedTableRowSelector_Click;

            Button linkedTableRowRemover = new Button()
            {
                Content = "Remove row",
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5, 0, 0, 0)
            };
            SetColumn(linkedTableRowRemover, 1);

            linkedTableRowRemover.Click += LinkedTableRowRemover_Click;

            //TextBlock linkedTableCountRowText = new TextBlock()
            //{
            //    Name = controlName + "Label",
            //    //Text = "IDs count:",
            //    VerticalAlignment = VerticalAlignment.Center,
            //    Margin = new Thickness(5, 0, 0, 0)
            //};

            //SetColumn(linkedTableCountRowText, 1);

            linkedTableControlsRowGrid.Children.Add(linkedTableRowAdder);
            linkedTableControlsRowGrid.Children.Add(linkedTableRowRemover);

            linkedTableSelectedIds = new ListBox()
            {
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Margin = new Thickness(0, 5, 0, 5)
            };

            SetRow(linkedTableSelectedIds, 2);
            Children.Add(linkedTableSelectedIds);
        }

        /// <summary>
        /// Remove linked table record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkedTableRowRemover_Click(object sender, RoutedEventArgs e)
        {
            if (linkedTableSelectedIds.SelectedItem != null)
                linkedTableSelectedIds.Items.Remove(linkedTableSelectedIds.SelectedItem);
        }

        /// <summary>
        /// Get selected IDs
        /// </summary>
        /// <returns>List of selected IDs</returns>
        public List<int> GetSelectedIds()
        {
            return linkedTableSelectedIds.Items.Select(x => (x as AtomicItem).Id).ToList();
        }

        /// <summary>
        /// Set selected items
        /// </summary>
        /// <param name="selectedItems">List of selected items</param>
        public void SetSelectedIds(List<AtomicItem> selectedItems)
        {
            foreach (var item in selectedItems)
            {
                linkedTableSelectedIds.Items.Add(item);
            }
        }

        /// <summary>
        /// Create linked table control
        /// </summary>
        /// <param name="controlName">Control name</param>
        /// <param name="controlData">Control data</param>
        /// <param name="controlType">Control type</param>
        /// <param name="linkedTableAttribute">Linked table attributes</param>
        /// <returns>Created control</returns>
        public static UIElement CreateLinkedTableControl(string controlName, PropertyAnalyze controlData, PropertyType controlType, LinkedTableAttribute linkedTableAttribute)
        {
            if (controlData is null)
                throw new Base.Exceptions.ArgumentNullException(nameof(controlData));

            if (controlType != PropertyType.Int && controlType != PropertyType.Int32)
                throw new Base.Exceptions.ArgumentOutOfRangeException(nameof(controlData), "Type of linked table presenter property must be integer.");

            if (!(controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) is UIParamsAttribute customization))
                throw new MissingRequiredAdditionalDataException("Linked table property require UIParams attribute for specificating design.");

            var control = new LinkedTableMultiSelectorControl(controlName, controlData, linkedTableAttribute)
            {
                Name = controlName + Constants.DATA_CONTROL_IDENTIFIER,
                Margin = new Thickness(10)
            };

            return control;
        }

        /// <summary>
        /// Add selected items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkedTableRowSelector_Click(object sender, RoutedEventArgs e)
        {
            LinkedTableSelector selector = new LinkedTableSelector(controlData);
            selector.ShowSelector(Selector_Closed, linkedTableSelectedIds.Items.Select(x => (x as AtomicItem).Id).ToList());
        }

        /// <summary>
        /// Selector closed
        /// </summary>
        /// <param name="result">Result of closing</param>
        /// <param name="selectedIds">Selected IDs</param>
        private void Selector_Closed(MessageDialogResult result, List<object> selectedIds)
        {
            if (result == MessageDialogResult.Ok && selectedIds.Count >= 1)
                SetSelectedIds(selectedIds.Cast<AtomicItem>().ToList());
        }
    }
}