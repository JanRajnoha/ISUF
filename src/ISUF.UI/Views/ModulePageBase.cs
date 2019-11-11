using ISUF.UI.App;
using ISUF.UI.Modules;
using ISUF.UI.Converters;
using ISUF.UI.ViewModel;
using System;
using System.Linq;
using Template10.Converters;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Data;
using System.Collections;
using Microsoft.Toolkit.Uwp.UI.Controls;
using ArgumentNullException = ISUF.Base.Exceptions.ArgumentNullException;
using Windows.UI;
using Windows.UI.Xaml.Markup;

namespace ISUF.UI.Views
{
    public class ModulePageBase : PageBase
    {
        UIModule uiModule;

        protected ColumnDefinition slaveFrameCD = new ColumnDefinition();
        protected ListView itemsList = new ListView();

        public ModulePageBase(Type viewModelType, params object[] viewModelArgs) : base(viewModelType, viewModelArgs)
        {
            uiModule = (UIModule)ApplicationBase.Current.ModuleManager.GetModules().Where(x => x is UIModule).FirstOrDefault(x => ((UIModule)x).ModulePage == GetType());
        }

        protected override void CreateViewModel()
        {
            var vmArgs = viewModelArgs.ToList();
            vmArgs.Insert(0, GetType());
            viewModelArgs = vmArgs.ToArray();

            base.CreateViewModel();
        }

        public override void AddControls()
        {
            var container = AddContainer();
            AddCommandBar(container);
            AddContent(container);
        }

        protected virtual Panel AddContainer()
        {
            RelativePanel Container = new RelativePanel
            {
                Name = "Container",
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Background = ApplicationBase.Current.Resources["SystemControlAcrylicWindowMediumHighBrush"] as Brush
            };
            Content = Container;

            return Container;
        }

        protected virtual void AddCommandBar(Panel container)
        {
            CommandBar PageHeader = new CommandBar
            {
                Name = "PageHeader",
                Style = ApplicationBase.Current.Resources["PageHeader"] as Style,
                Margin = new Thickness(0, 32, 0, 0)
            };

            AppBarButton AddItem = new AppBarButton()
            {
                Label = "Add " + (DataContext as ViewModelBase).GetPropertyValue("ModuleName") as string,
                Icon = new SymbolIcon(Symbol.Add),
                IsEnabled = true,
                Template = ApplicationBase.Current.Resources["ShadowAppBarButton"] as ControlTemplate,
                Style = ApplicationBase.Current.Resources["AppBarButtonRevealLabelsOnRightStyle"] as Style,
                Command = null
            };

            ToolTipService.SetToolTip(AddItem, "Add new " + (DataContext as ViewModelBase).GetPropertyValue("ModuleName") as string + " (Ctrl + N)");
            KeyboardAccelerator addItemKeyboardAccelerator = new KeyboardAccelerator()
            {
                Modifiers = VirtualKeyModifiers.Control,
                Key = VirtualKey.N
            };
            AddItem.KeyboardAccelerators.Add(addItemKeyboardAccelerator);

            PageHeader.PrimaryCommands.Add(AddItem);

            AppBarButton SlavePane = new AppBarButton()
            {
                Template = ApplicationBase.Current.Resources["ShadowAppBarButton"] as ControlTemplate,
                Style = ApplicationBase.Current.Resources["AppBarButtonRevealLabelsOnRightStyle"] as Style,
                Command = null
            };

            ToolTipService.SetToolTip(SlavePane, "Open/Close slave pane (Ctrl + O)");
            KeyboardAccelerator openSlavePaneKeyboardAccelerator = new KeyboardAccelerator()
            {
                Modifiers = VirtualKeyModifiers.Control,
                Key = VirtualKey.N
            };
            SlavePane.KeyboardAccelerators.Add(openSlavePaneKeyboardAccelerator);

            Binding slavePaneLabelBinding = new Binding()
            {
                Path = new PropertyPath(nameof(ColumnDefinition.Width)),
                ElementName = nameof(slaveFrameCD),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new SlavePaneVisibilityConverter(),
                ConverterParameter = "text"
            };
            BindingOperations.SetBinding(SlavePane, AppBarButton.LabelProperty, slavePaneLabelBinding);

            Binding slavePaneIconBinding = new Binding()
            {
                Path = new PropertyPath(nameof(ColumnDefinition.Width)),
                ElementName = nameof(slaveFrameCD),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new SlavePaneVisibilityConverter(),
                ConverterParameter = "icon"
            };
            BindingOperations.SetBinding(SlavePane, AppBarButton.IconProperty, slavePaneIconBinding);

            Binding slavePaneIsEnabledBinding = new Binding()
            {
                Source = ((DataContext as ViewModelBase).GetPropertyValue("PivotPanes") as IList).Count,
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new IntToBoolConverter()
            };
            BindingOperations.SetBinding(SlavePane, AppBarButton.IsEnabledProperty, slavePaneIsEnabledBinding);
            ApplicationBase.Current.PropertyChangedNotifier.RegisterProperty(SlavePane, AppBarButton.IsEnabledProperty, "PivotPanes", viewModelType, "Count", converter: new IntToBoolConverter());

            PageHeader.PrimaryCommands.Add(SlavePane);

            AppBarButton SelectItems = new AppBarButton()
            {
                Template = ApplicationBase.Current.Resources["ShadowAppBarButton"] as ControlTemplate,
                Style = ApplicationBase.Current.Resources["AppBarButtonRevealLabelsOnRightStyle"] as Style,
                Icon = new SymbolIcon(Symbol.Bullets),
                Name = nameof(SelectItems),
                Command = null
            };

            //xxx            ToolTipService.SetToolTip(SlavePane, "Open/Close slave pane (Ctrl + O)");
            //KeyboardAccelerator selectItemsKeyboardAccelerator = new KeyboardAccelerator()
            //{
            //    Modifiers = VirtualKeyModifiers.Control,
            //    Key = VirtualKey.X
            //};
            //SlavePane.KeyboardAccelerators.Add(selectItemsKeyboardAccelerator);

            Binding selectItemsLabelBinding = new Binding()
            {
                Path = new PropertyPath(nameof(ListView.SelectionMode)),
                ElementName = nameof(itemsList),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new LabelConverter()
            };
            BindingOperations.SetBinding(SelectItems, AppBarButton.LabelProperty, selectItemsLabelBinding);

            ValueWhenConverter SlidableItemIsEnabled = new ValueWhenConverter
            {
                When = ListViewSelectionMode.Multiple,
                Value = false,
                Otherwise = true
            };

            Binding selectItemsIsEnabledBinding = new Binding()
            {
                Path = new PropertyPath(nameof(ListView.SelectionMode)),
                ElementName = nameof(itemsList),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = SlidableItemIsEnabled
            };
            BindingOperations.SetBinding(SelectItems, AppBarButton.IsEnabledProperty, selectItemsIsEnabledBinding);

            AppBarButton CancelSelectItems = new AppBarButton()
            {
                Template = ApplicationBase.Current.Resources["ShadowAppBarButton"] as ControlTemplate,
                Style = ApplicationBase.Current.Resources["AppBarButtonRevealLabelsOnRightStyle"] as Style,
                Icon = new SymbolIcon(Symbol.Bullets),
                Command = null
            };

            Binding selectItemsVisibilityBinding = new Binding()
            {
                Path = new PropertyPath(nameof(AppBarButton.Visibility)),
                ElementName = nameof(CancelSelectItems),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new InvertVisibilityConverter()
            };
            BindingOperations.SetBinding(SelectItems, AppBarButton.VisibilityProperty, selectItemsVisibilityBinding);

            PageHeader.PrimaryCommands.Add(SelectItems);

            //xxx            ToolTipService.SetToolTip(SlavePane, "Open/Close slave pane (Ctrl + O)");
            KeyboardAccelerator cancelSelectItemsKeyboardAccelerator = new KeyboardAccelerator()
            {
                Key = VirtualKey.Escape
            };
            CancelSelectItems.KeyboardAccelerators.Add(cancelSelectItemsKeyboardAccelerator);

            Binding cancelSelectItemsLabelBinding = new Binding()
            {
                Path = new PropertyPath(nameof(ListView.SelectionMode)),
                ElementName = nameof(itemsList),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new LabelConverter()
            };
            BindingOperations.SetBinding(CancelSelectItems, AppBarButton.LabelProperty, cancelSelectItemsLabelBinding);

            Binding cancelSelectItemsIsEnabledBinding = new Binding()
            {
                Path = new PropertyPath(nameof(AppBarButton.IsEnabled)),
                ElementName = nameof(SelectItems),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new InvertBoolConverter()
            };
            BindingOperations.SetBinding(CancelSelectItems, AppBarButton.IsEnabledProperty, cancelSelectItemsIsEnabledBinding);

            ValueWhenConverter SelectItemsMode = new ValueWhenConverter
            {
                When = ListViewSelectionMode.Multiple,
                Value = Visibility.Visible,
                Otherwise = Visibility.Collapsed
            };

            Binding cancelSelectItemsVisibilityBinding = new Binding()
            {
                Path = new PropertyPath(nameof(ListView.SelectionMode)),
                ElementName = nameof(itemsList),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = SelectItemsMode
            };
            BindingOperations.SetBinding(CancelSelectItems, AppBarButton.VisibilityProperty, cancelSelectItemsVisibilityBinding);

            PageHeader.PrimaryCommands.Add(CancelSelectItems);

            AppBarButton SelectAllItems = new AppBarButton()
            {
                Name = nameof(SelectAllItems),
                Label = "Select all",
                Template = ApplicationBase.Current.Resources["ShadowAppBarButton"] as ControlTemplate,
                Style = ApplicationBase.Current.Resources["AppBarButtonRevealLabelsOnRightStyle"] as Style,
                Icon = new SymbolIcon(Symbol.SelectAll),
                Command = null
            };

            ToolTipService.SetToolTip(SelectAllItems, "Select all (Ctrl + A)");
            KeyboardAccelerator selectAllItemsKeyboardAccelerator = new KeyboardAccelerator()
            {
                Key = VirtualKey.A,
                Modifiers = VirtualKeyModifiers.Control
            };
            SelectAllItems.KeyboardAccelerators.Add(selectAllItemsKeyboardAccelerator);

            Binding selectAllItemsVisibilityBinding = new Binding()
            {
                Path = new PropertyPath(nameof(ListView.SelectionMode)),
                ElementName = nameof(itemsList),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = SelectItemsMode
            };
            BindingOperations.SetBinding(SelectAllItems, AppBarButton.VisibilityProperty, selectAllItemsVisibilityBinding);

            PageHeader.PrimaryCommands.Add(SelectAllItems);

            AppBarButton ShareItems = new AppBarButton()
            {
                Name = nameof(ShareItems),
                Label = "Share",
                Template = ApplicationBase.Current.Resources["ShadowAppBarButton"] as ControlTemplate,
                Style = ApplicationBase.Current.Resources["AppBarButtonRevealLabelsOnRightStyle"] as Style,
                Icon = new SymbolIcon(Symbol.SelectAll),
                Command = null
            };

            ToolTipService.SetToolTip(ShareItems, "Share");

            Binding shareItemsCommandParameterBinding = new Binding() 
            {
                ElementName = nameof(itemsList),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            BindingOperations.SetBinding(ShareItems, AppBarButton.CommandParameterProperty, shareItemsCommandParameterBinding);

            Binding shareItemsVisibilityBinding = new Binding()
            {
                Path = new PropertyPath(nameof(ListView.SelectionMode)),
                ElementName = nameof(itemsList),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = SelectItemsMode
            };
            BindingOperations.SetBinding(ShareItems, AppBarButton.VisibilityProperty, shareItemsVisibilityBinding);

            PageHeader.PrimaryCommands.Add(ShareItems);

            AppBarButton DeleteItems = new AppBarButton()
            {
                Name = nameof(SelectAllItems),
                Label = "Delete items",
                Template = ApplicationBase.Current.Resources["ShadowAppBarButton"] as ControlTemplate,
                Style = ApplicationBase.Current.Resources["AppBarButtonRevealLabelsOnRightStyle"] as Style,
                Icon = new SymbolIcon(Symbol.Delete),
                Command = null
            };

            ToolTipService.SetToolTip(DeleteItems, "Delete (Delete)");
            KeyboardAccelerator deleteItemsKeyboardAccelerator = new KeyboardAccelerator()
            {
                Key = VirtualKey.Delete,
                Modifiers = VirtualKeyModifiers.None
            };
            DeleteItems.KeyboardAccelerators.Add(deleteItemsKeyboardAccelerator);

            Binding deleteItemsCommandParameterBinding = new Binding()
            {
                ElementName = nameof(itemsList),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            BindingOperations.SetBinding(DeleteItems, AppBarButton.CommandParameterProperty, deleteItemsCommandParameterBinding);

            Binding deleteItemsVisibilityBinding = new Binding()
            {
                Path = new PropertyPath(nameof(ListView.SelectionMode)),
                ElementName = nameof(itemsList),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = SelectItemsMode
            };
            BindingOperations.SetBinding(DeleteItems, AppBarButton.IsEnabledProperty, deleteItemsVisibilityBinding);

            PageHeader.PrimaryCommands.Add(DeleteItems);

            AppBarButton CreateSecondTile = new AppBarButton()
            {
                Name = nameof(SelectAllItems),
                Label = "Select all",
                Template = ApplicationBase.Current.Resources["ShadowAppBarButton"] as ControlTemplate,
                Style = ApplicationBase.Current.Resources["AppBarButtonRevealLabelsOnRightStyle"] as Style,
                Icon = new SymbolIcon(Symbol.SelectAll),
                Command = null
            };

            ToolTipService.SetToolTip(CreateSecondTile, "Add/Remove second tile");

            Binding createSecondTileLabelBinding = new Binding()
            {
                Source = (DataContext as ViewModelBase).GetPropertyValue("StartTileAdded"),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new SecondaryTileExistConverter(),
                ConverterParameter = "text"
            };
            BindingOperations.SetBinding(CreateSecondTile, AppBarButton.LabelProperty, createSecondTileLabelBinding);
            ApplicationBase.Current.PropertyChangedNotifier.RegisterProperty(CreateSecondTile, AppBarButton.LabelProperty, "StartTileAdded", viewModelType, converter: new SecondaryTileExistConverter(), converterParameter: "text");

            Binding createSecondTileIconBinding = new Binding()
            {
                Source = (DataContext as ViewModelBase).GetPropertyValue("StartTileAdded"),
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = new SecondaryTileExistConverter(),
                ConverterParameter = "icon"
            };
            BindingOperations.SetBinding(CreateSecondTile, AppBarButton.IconProperty, createSecondTileIconBinding);
            ApplicationBase.Current.PropertyChangedNotifier.RegisterProperty(CreateSecondTile, AppBarButton.IconProperty, "StartTileAdded", viewModelType, converter: new SecondaryTileExistConverter(), converterParameter: "icon");

            PageHeader.PrimaryCommands.Add(CreateSecondTile);

            TextBlock title = new TextBlock
            {
                Text = (DataContext as ViewModelBase).GetPropertyValue("ModuleTitle") as string,
                Style = ApplicationBase.Current.Resources["PageHeaderText"] as Style
            };
            PageHeader.Content = title;

            container.Children.Add(PageHeader);
        }

        protected virtual void AddContent(Panel container)
        {
            if (container == null)
                throw new ArgumentNullException("Parameter container is null.");

            var pageHeader = container.Children.FirstOrDefault(x => (x as FrameworkElement).Name == "PageHeader");

            DropShadowPanel ShadowPanel = new DropShadowPanel()
            {
                Style = ApplicationBase.Current.Resources["ShadowContent"] as Style,
                HorizontalContentAlignment = HorizontalAlignment.Stretch,
                VerticalContentAlignment = VerticalAlignment.Stretch,
            };
            RelativePanel.SetBelow(ShadowPanel, pageHeader);
            RelativePanel.SetAlignBottomWithPanel(ShadowPanel, true);
            RelativePanel.SetAlignRightWithPanel(ShadowPanel, true);
            RelativePanel.SetAlignLeftWithPanel(ShadowPanel, true);

            Grid ContentGrid = new Grid
            {
                Style = ApplicationBase.Current.Resources["ContentGrid"] as Style
            };

            ColumnDefinition MasterFrame = new ColumnDefinition();

            Binding masterFrameWidthBinding = new Binding()
            {
                Source = (GridLength)(DataContext as ViewModelBase).GetPropertyValue("MasterFrame"),
                Mode = BindingMode.OneWay
            };
            BindingOperations.SetBinding(MasterFrame, ColumnDefinition.WidthProperty, masterFrameWidthBinding);
            ApplicationBase.Current.PropertyChangedNotifier.RegisterProperty(MasterFrame, ColumnDefinition.WidthProperty, "MasterFrame", viewModelType);

            slaveFrameCD = new ColumnDefinition();
            slaveFrameCD.SetValue(FrameworkElement.NameProperty, "slaveFrameCD");

            Binding slaveFrameCDWidthBinding = new Binding()
            {
                Source = (DataContext as ViewModelBase).GetPropertyValue("PaneVisibility"),
                Mode = BindingMode.OneWay,
                Converter = new BoolToGridVisibilityConverter()
            };
            BindingOperations.SetBinding(slaveFrameCD, ColumnDefinition.WidthProperty, slaveFrameCDWidthBinding);
            ApplicationBase.Current.PropertyChangedNotifier.RegisterProperty(slaveFrameCD, ColumnDefinition.WidthProperty, "PaneVisibility", viewModelType, converter: new BoolToGridVisibilityConverter());

            ContentGrid.ColumnDefinitions.Add(MasterFrame);
            ContentGrid.ColumnDefinitions.Add(slaveFrameCD);

            //ListView asd = new ListView()
            //{
            //    Margin = new Thickness(0, 10, 0, 0),
            //    HorizontalAlignment = HorizontalAlignment.Stretch,
            //    Background = new SolidColorBrush(Color.FromArgb(125, 125, 0, 255))
            //};

            //ContentGrid.Children.Add(asd);

            ShadowPanel.Content = ContentGrid;
            container.Children.Add(ShadowPanel);
        }
    }
}
