using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ISUF.UI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public abstract class MainPageBase : Page
    {
        protected Type viewModelType;

        public MainPageBase(Type viewModelType)
        {
            //LoadResources();

            this.viewModelType = viewModelType;
            //AddControls();
            Loading += MainPage_Loading;
        }

        protected abstract void MainPage_Loading(FrameworkElement sender, object args);

        public void AddControls()
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
                Style = Application.Current.Resources["PageHeader"] as Style
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

            var pageHeader = container.Children.FirstOrDefault(x => ((FrameworkElement)x).Name == "PageHeader");

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
                Padding = new Thickness(5),
                ItemsSource = new List<string>() // TODO
            };

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
