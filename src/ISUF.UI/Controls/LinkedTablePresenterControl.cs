using ISUF.Base.Attributes;
using ISUF.Base.Enum;
using ISUF.Base.Exceptions;
using ISUF.Base.Modules;
using ISUF.UI.Classes;
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
    public class LinkedTablePresenterControl : Grid
    {
        private IList<int> presentedLinkedIds = new List<int>();

        public LinkedTablePresenterControl()
        {

        }

        public IList<int> GetSelectedIds()
        {
            return presentedLinkedIds;
        }

        public static UIElement CreateLinkedTablePresenterControl(string controlName, PropertyAnalyze controlData, PropertyType controlType)
        {
            if (controlData is null)
                throw new Base.Exceptions.ArgumentNullException(nameof(controlData));

            if (controlType != PropertyType.Int && controlType != PropertyType.Int32)
                throw new Base.Exceptions.ArgumentOutOfRangeException(nameof(controlData), "Type of linked table presenter property must be integer.");

            if (!(controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) is UIParamsAttribute customization))
                throw new MissingRequiredAdditionalDataException("Linked table property require UIParams attribute for specificating design.");

            var control = new LinkedTablePresenterControl()
            {
                Name = controlName + Constants.DATA_CONTROL_IDENTIFIER,
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

            RowDefinition linkedTablePresenterRow = new RowDefinition()
            {
                Height = new GridLength(150, GridUnitType.Pixel)
            };

            control.RowDefinitions.Add(labelRow);
            control.RowDefinitions.Add(linkedTableControlsRow);
            control.RowDefinitions.Add(linkedTablePresenterRow);

            TextBlock label = new TextBlock()
            {
                Name = controlName + Constants.LABEL_CONTROL_IDENTIFIER,
                Text = customization.LabelDescription,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 0, 5)
            };
            SetRow(label, 0);
            control.Children.Add(label);

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
            control.Children.Add(linkedTableControlsRowGrid);

            Button linkedTableRowAdder = new Button()
            {
                Content = "Add row",
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 5, 0)
            };

            Button linkedTableRowRemover = new Button()
            {
                Content = "Remove row",
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5, 0, 0, 0)
            };

            SetColumn(linkedTableRowRemover, 1);

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

            ListBox linkedTableSelectedIds = new ListBox()
            {
                Background = new SolidColorBrush(Colors.Red),
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 0, 5)
            };

            SetRow(linkedTableSelectedIds, 2);

            return control;
        }
    }
}
