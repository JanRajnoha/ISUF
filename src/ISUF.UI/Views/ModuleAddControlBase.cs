using ISUF.Base.Attributes;
using ISUF.Base.Modules;
using ISUF.Base.Template;
using ISUF.UI.App;
using ISUF.UI.Converters;
using ISUF.UI.Design;
using ISUF.UI.Modules;
using ISUF.UI.ViewModel;
using System;
using System.Linq;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace ISUF.UI.Views
{

    public class ModuleAddControlBase : ControlBase
    {
        Panel mainContent;
        readonly UIModule uiModule;

        public ModuleAddControlBase(UIModule uiModule, Type viewModelType, params object[] viewModelArgs) : base(viewModelType, viewModelArgs)
        {
            this.uiModule = uiModule;
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
            AddCloseRow.SetValue(NameProperty, nameof(AddCloseRow));

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
                VerticalAlignment = VerticalAlignment.Stretch,
                Command = (DataContext as ViewModelBase).GetPropertyValue("SaveItemClose") as ICommand,
                CommandParameter = (DataContext as ViewModelBase).GetPropertyValue("AddEditItem")
            };
            Grid.SetRow(AddClose, 0);
            Grid.SetColumnSpan(AddClose, 2);

            Binding addCloseRowHeightBinding = new Binding()
            {
                Path = new PropertyPath(nameof(Button.Visibility)),
                ElementName = nameof(AddClose),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new VisibilityToGridLength()
            };
            BindingOperations.SetBinding(AddCloseRow, RowDefinition.HeightProperty, addCloseRowHeightBinding);

            Binding gridRowHeightBinding = new Binding()
            {
                Path = new PropertyPath(nameof(Button.Visibility)),
                ElementName = nameof(AddClose),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new AddCloseVisibilityConverter()
            };
            BindingOperations.SetBinding(buttonsRow, RowDefinition.HeightProperty, gridRowHeightBinding);

            Binding addCloseVisibilityBinding = new Binding()
            {
                Source = ((DataContext as ViewModelBase).GetPropertyValue("AddEditItem") as AtomicItem).Id,
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new IdConverter(),
                ConverterParameter = "visibility"
            };
            BindingOperations.SetBinding(AddClose, Button.VisibilityProperty, addCloseVisibilityBinding);
            ApplicationBase.Current.PropertyChangedNotifier.RegisterProperty(AddClose, Button.VisibilityProperty, "AddEditItem", viewModelType, "Id", converter: new IdConverter(), converterParameter: "visibility");

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
                VerticalAlignment = VerticalAlignment.Stretch,
                Command = (DataContext as ViewModelBase).GetPropertyValue("SaveItem") as ICommand,
                CommandParameter = (DataContext as ViewModelBase).GetPropertyValue("AddEditItem")
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

            Binding addTextBinding = new Binding()
            {
                Source = ((DataContext as ViewModelBase).GetPropertyValue("AddEditItem") as AtomicItem).Id,
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new IdConverter(),
                ConverterParameter = "text"
            };
            BindingOperations.SetBinding(AddText, TextBlock.TextProperty, addTextBinding);
            ApplicationBase.Current.PropertyChangedNotifier.RegisterProperty(AddText, TextBlock.TextProperty, "AddEditItem", viewModelType, "Id", converter: new IdConverter(), converterParameter: "text");

            addContent.Children.Add(addIcon);
            addContent.Children.Add(AddText);
            Add.Content = addContent;
            ToolTipService.SetToolTip(Add, "Add (Ctrl + S)");

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
                VerticalAlignment = VerticalAlignment.Stretch,
                Command = (DataContext as ViewModelBase).GetPropertyValue("Close") as ICommand
            };
            Grid.SetRow(Cancel, 1);
            Grid.SetColumn(Cancel, 1);

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

            KeyboardAccelerator cancelKeyboardAccelerator = new KeyboardAccelerator()
            {
                Key = VirtualKey.Escape
            };
            Cancel.KeyboardAccelerators.Add(cancelKeyboardAccelerator);

            buttonsPart.Children.Add(AddClose);
            buttonsPart.Children.Add(Add);
            buttonsPart.Children.Add(Cancel);
            content.Children.Add(buttonsPart);

            Content = content;
        }

        public override void CreateControlsForModule()
        {
            var result = ApplicationBase.Current.ModuleAnalyser.SortProperties(uiModule.ModuleItemType);

            UIElement previousControl = null;

            foreach (var item in result)
            {
                if (item.Value.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIIgnoreAttribute)) != null)
                    continue;

                mainContent.Children.Add(ControlCreator.CreateEditableControl(item, ref previousControl));
            }
        }
    }
}
