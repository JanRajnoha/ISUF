using ISUF.UI.App;
using ISUF.UI.ViewModel;
using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace ISUF.UI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public abstract class MainPageBase : PageBase
    {
        protected Type viewModelType;
        protected object[] viewModelArgs;

        public MainPageBase(Type viewModelType, params object[] viewModelArgs)
        {
            this.viewModelType = viewModelType;
            this.viewModelArgs = viewModelArgs;

            CreateViewModel();

            Loading += MainPage_Loading;
        }

        private void CreateViewModel()
        {
            object viewModel = Activator.CreateInstance(viewModelType, viewModelArgs);
            (Application.Current as ApplicationBase).VMLocator.AddViewModel(viewModel);
        }

        protected void MainPage_Loading(FrameworkElement sender, object args)
        {
            DataContext = (Application.Current as ApplicationBase).VMLocator.GetViewModel(viewModelType);
            AddControls();
        }

        public override void AddControls()
        {
            var container = AddContainer();
            AddCommandBar(container);
            AddModuleMenu(container);
        }

        public Panel AddContainer()
        {
            RelativePanel Container = new RelativePanel
            {
                Name = "Container",
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Background = Application.Current.Resources["PageHeader"] as Brush
            };
            Content = Container;

            return Container;
        }

        public void AddCommandBar(Panel container)
        {
            CommandBar PageHeader = new CommandBar
            {
                Name = "PageHeader",
                Style = Application.Current.Resources["PageHeader"] as Style,
                Margin = new Thickness(0, 32, 0, 0)
            };

            AppBarButton settings = new AppBarButton
            {
                Label = "Settings"
            };
            SymbolIcon settingsSymbol = new SymbolIcon(Symbol.Setting);
            settings.Icon = settingsSymbol;
            PageHeader.PrimaryCommands.Add(settings);

            TextBlock title = new TextBlock
            {
                Text = "Home",
                Style = Application.Current.Resources["PageHeaderText"] as Style
            };
            PageHeader.Content = title;

            container.Children.Add(PageHeader);
        }

        public void AddModuleMenu(Panel container)
        {
            if (container == null)
                return;

            var pageHeader = container.Children.FirstOrDefault(x => (x as FrameworkElement).Name == "PageHeader");

            DropShadowPanel ShadowPanel = new DropShadowPanel
            {
                Style = Application.Current.Resources["ShadowContent"] as Style,
                HorizontalContentAlignment = HorizontalAlignment.Stretch,
                VerticalContentAlignment = VerticalAlignment.Stretch
            };
            RelativePanel.SetBelow(ShadowPanel, pageHeader);
            RelativePanel.SetAlignBottomWithPanel(ShadowPanel, true);
            RelativePanel.SetAlignRightWithPanel(ShadowPanel, true);
            RelativePanel.SetAlignLeftWithPanel(ShadowPanel, true);

            Grid ContentGrid = new Grid
            {
                Style = Application.Current.Resources["ContentGrid"] as Style
            };

            RowDefinition RowMain = new RowDefinition();
            RowDefinition MinorUpdateRow = new RowDefinition // TODO
            {
                Height = new GridLength(60)
            };

            ContentGrid.RowDefinitions.Add(RowMain);
            ContentGrid.RowDefinitions.Add(MinorUpdateRow);

            ListView MainPageMenu = new ListView
            {
                Name = "MainPageMenu",
                Padding = new Thickness(5)
            };

            var menuItemTemplate = "<DataTemplate xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\">" +
                "<Grid>" +
                "<Grid.ColumnDefinitions>" +
                "<ColumnDefinition Width=\"30\"/>" +
                "<ColumnDefinition/>" +
                "</Grid.ColumnDefinitions>" +
                "<SymbolIcon Symbol=\"{Binding ModuleDisplayIcon}\" HorizontalAlignment=\"Left\" Margin=\"5 0 0 0\"/>" +
                "<TextBlock Grid.Column=\"1\" Text=\"{Binding ModuleDisplayName}\" Margin=\"15 0 0 0\"/>" +
                "</Grid>" +
                "</DataTemplate>";
            MainPageMenu.ItemTemplate = (DataTemplate)XamlReader.Load(menuItemTemplate);

            Binding modulesMenuBinding = new Binding
            {
                Source = (DataContext as MainPageVMBase).AppModules,
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            BindingOperations.SetBinding(MainPageMenu, ListView.ItemsSourceProperty, modulesMenuBinding);

            RelativePanel MinorUpdatePanel = new RelativePanel();
            Grid.SetRow(MinorUpdatePanel, 1);

            DropShadowPanel MinorUpdateShadow = new DropShadowPanel
            {
                Style = Application.Current.Resources["ShadowContent"] as Style,
                HorizontalContentAlignment = HorizontalAlignment.Stretch,
                VerticalContentAlignment = VerticalAlignment.Stretch
            };
            RelativePanel.SetAlignTopWithPanel(MinorUpdateShadow, true);
            RelativePanel.SetAlignBottomWithPanel(MinorUpdateShadow, true);
            RelativePanel.SetAlignRightWithPanel(MinorUpdateShadow, true);
            RelativePanel.SetAlignLeftWithPanel(MinorUpdateShadow, true);

            Grid MinorUpdateContent = new Grid
            {
                Style = Application.Current.Resources["ContentGrid"] as Style,
                HorizontalAlignment = HorizontalAlignment.Stretch
            };

            Button MinorUpdateClose = new Button
            {
                Background = new SolidColorBrush(Windows.UI.Colors.Transparent),
                Content = "",
                Height = 40,
                Width = 40,
                FontFamily = new FontFamily("Segoe MDL2 Assets"),
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Right,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                Command = null, // TODO
                Margin = new Thickness(0, 0, 10, 0)
            };

            TextBlock MinorUpdateText = new TextBlock
            {
                Text = "Your app has been udpated to version " + "1.1.1", // TODO
                Margin = new Thickness(10, 10, 50, 10),
                VerticalAlignment = VerticalAlignment.Center
            };

            MinorUpdateContent.Children.Add(MinorUpdateClose);
            MinorUpdateContent.Children.Add(MinorUpdateText);
            MinorUpdateShadow.Content = MinorUpdateContent;
            MinorUpdatePanel.Children.Add(MinorUpdateShadow);
            ContentGrid.Children.Add(MainPageMenu);
            ContentGrid.Children.Add(MinorUpdatePanel);
            ShadowPanel.Content = ContentGrid;
            container.Children.Add(ShadowPanel);
        }
    }
}
