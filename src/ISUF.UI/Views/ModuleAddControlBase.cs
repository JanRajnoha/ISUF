using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace ISUF.UI.Views
{

    public class ModuleAddControlBase : ControlBase
    {
        Panel mainContent;

        public ModuleAddControlBase()
        {

        }

        public override void AddControls()
        {
            Grid content = new Grid();

            RowDefinition mainRow = new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Star)
            };

            RowDefinition buttonsRow = new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Star)
            };
            // binding

            content.RowDefinitions.Add(mainRow);
            content.RowDefinitions.Add(buttonsRow);

            ScrollViewer mainScrollView = new ScrollViewer()
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                VerticalScrollMode = ScrollMode.Enabled
            };
            Grid.SetRow(mainScrollView, 0);

            mainContent = new RelativePanel();
            mainScrollView.Content = mainContent;

            content.Children.Add(mainScrollView);



            Grid buttonsPart = new Grid();
            Grid.SetRow(buttonsPart, 1);

            ColumnDefinition col1 = new ColumnDefinition()
            {
                Width = new GridLength(1, GridUnitType.Star)
            };

            ColumnDefinition col2 = new ColumnDefinition()
            {
                Width = new GridLength(1, GridUnitType.Star)
            }; 

            buttonsPart.ColumnDefinitions.Add(col1);
            buttonsPart.ColumnDefinitions.Add(col2);

            RowDefinition AddCloseRow = new RowDefinition();
            AddCloseRow.SetValue(FrameworkElement.NameProperty, nameof(AddCloseRow));
            // binding

            RowDefinition row2 = new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Star)
            };

            buttonsPart.RowDefinitions.Add(AddCloseRow);
            buttonsPart.RowDefinitions.Add(row2);

            Button AddClose = new Button()
            {
                Name = nameof(AddClose),
                Margin = new Thickness(0, 0, 0, 1),
                FontSize = 15,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };
            Grid.SetRow(AddClose, 0);
            Grid.SetColumnSpan(AddClose, 2);

            StackPanel addCloseContent = new StackPanel()
            {
                Orientation = Orientation.Horizontal
            };

            SymbolIcon addCloseIcon = new SymbolIcon(Symbol.SaveLocal)
            {
                Margin = new Thickness(0, 0, 10, 0)
            };

            TextBlock addCloseText = new TextBlock()
            {
                Text = "Add and Close"
            };

            addCloseContent.Children.Add(addCloseIcon);
            addCloseContent.Children.Add(addCloseText);
            AddClose.Content = addCloseContent;

            ToolTipService.SetToolTip(AddClose, "Add and Close (Ctrl + Shift + S)");

            KeyboardAccelerator addCloseKeyboardAccelerator = new KeyboardAccelerator()
            {
                Key = VirtualKey.S,
                Modifiers = VirtualKeyModifiers.Control | VirtualKeyModifiers.Shift
            };
            AddClose.KeyboardAccelerators.Add(addCloseKeyboardAccelerator);

            Button Add = new Button()
            {
                Name = nameof(Add),
                Margin = new Thickness(0, 1, 1, 1),
                FontSize = 15,
                IsEnabled = true,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };
            Grid.SetRow(Add, 1);
            Grid.SetColumn(Add, 0);

            StackPanel addContent = new StackPanel()
            {
                Orientation = Orientation.Horizontal
            };

            SymbolIcon addIcon = new SymbolIcon(Symbol.Save)
            {
                Margin = new Thickness(0, 0, 10, 0)
            };

            TextBlock AddText = new TextBlock()
            {
                Name = nameof(AddText)
            };
            // Binding

            addContent.Children.Add(addIcon);
            addContent.Children.Add(AddText);
            Add.Content = addContent;
            ToolTipService.SetToolTip(Add, "Add (Ctrl + S)");
            // BInding

            KeyboardAccelerator addKeyboardAccelerator = new KeyboardAccelerator()
            {
                Key = VirtualKey.S,
                Modifiers = VirtualKeyModifiers.Control
            };
            Add.KeyboardAccelerators.Add(addKeyboardAccelerator);

            Button Cancel = new Button()
            {
                Name = nameof(Cancel),
                Margin = new Thickness(1, 1, 0, 1),
                FontSize = 15,
                IsEnabled = true,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };
            Grid.SetRow(Add, 1);
            Grid.SetColumn(Add, 1);

            StackPanel cancelContent = new StackPanel()
            {
                Orientation = Orientation.Horizontal
            };

            SymbolIcon cancelIcon = new SymbolIcon(Symbol.Cancel)
            {
                Margin = new Thickness(0, 0, 10, 0)
            };

            TextBlock cancelText = new TextBlock()
            {
                Text = "Cancel"
            };

            cancelContent.Children.Add(cancelIcon);
            cancelContent.Children.Add(cancelText);
            Cancel.Content = cancelContent;
            ToolTipService.SetToolTip(Cancel, "Cancel (Esc)");
            // BInding

            KeyboardAccelerator cancelKeyboardAccelerator = new KeyboardAccelerator()
            {
                Key = VirtualKey.Escape
            };
            Cancel.KeyboardAccelerators.Add(cancelKeyboardAccelerator);
        }

        public override void CreateControlsForModule()
        {
        }
    }
}
