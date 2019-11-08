using ISUF.UI.App;
using ISUF.UI.Classes;
using ISUF.UI.ViewModel;
using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Converters;
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
        protected ListView mainPageMenu;

        public MainPageBase(Type viewModelType, params object[] viewModelArgs) : base(viewModelType, viewModelArgs)
        { 
        }

        public override void AddControls()
        {
            var container = AddContainer();
            AddCommandBar(container);
            AddModuleMenu(container);
        }

        public virtual Panel AddContainer()
        {
            RelativePanel Container = new RelativePanel
            {
                Name = "Container",
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Background = ApplicationBase.Current.Resources["PageHeader"] as Brush
            };
            Content = Container;

            return Container;
        }

        public virtual void AddCommandBar(Panel container)
        {
            CommandBar PageHeader = new CommandBar
            {
                Name = "PageHeader",
                Style = ApplicationBase.Current.Resources["PageHeader"] as Style,
                Margin = new Thickness(0, 32, 0, 0)
            };

            AppBarButton settings = new AppBarButton
            {
                Label = "Settings",
                Icon = new SymbolIcon(Symbol.Setting)
            };
            settings.Click += GoToSettings;
            PageHeader.PrimaryCommands.Add(settings);

            TextBlock title = new TextBlock
            {
                Text = "Home",
                Style = ApplicationBase.Current.Resources["PageHeaderText"] as Style
            };
            PageHeader.Content = title;

            container.Children.Add(PageHeader);
        }

        public virtual void AddModuleMenu(Panel container)
        {
            if (container == null)
                return;

            var pageHeader = container.Children.FirstOrDefault(x => (x as FrameworkElement).Name == "PageHeader");

            DropShadowPanel ShadowPanel = new DropShadowPanel
            {
                Style = ApplicationBase.Current.Resources["ShadowContent"] as Style,
                HorizontalContentAlignment = HorizontalAlignment.Stretch,
                VerticalContentAlignment = VerticalAlignment.Stretch
            };
            RelativePanel.SetBelow(ShadowPanel, pageHeader);
            RelativePanel.SetAlignBottomWithPanel(ShadowPanel, true);
            RelativePanel.SetAlignRightWithPanel(ShadowPanel, true);
            RelativePanel.SetAlignLeftWithPanel(ShadowPanel, true);

            Grid ContentGrid = new Grid
            {
                Style = ApplicationBase.Current.Resources["ContentGrid"] as Style
            };

            RowDefinition RowMain = new RowDefinition();
            RowDefinition MinorUpdateRow = new RowDefinition();

            ValueWhenConverter boolToGridLength = new ValueWhenConverter
            {
                When = true,
                Value = new GridLength(50),
                Otherwise = new GridLength(0)
            };

            Binding minorUpdateRowBinding = new Binding
            {
                Source = (DataContext as MainPageVMBase).ShowMinorUpdate,
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Converter = boolToGridLength
            };
            BindingOperations.SetBinding(MinorUpdateRow, RowDefinition.HeightProperty, minorUpdateRowBinding);

            var MPVMB = DataContext as MainPageVMBase;
            ApplicationBase.Current.PropertyChangedNotifier.RegisterProperty(MinorUpdateRow, RowDefinition.HeightProperty, boolToGridLength, nameof(MPVMB.ShowMinorUpdate));

            ContentGrid.RowDefinitions.Add(RowMain);
            ContentGrid.RowDefinitions.Add(MinorUpdateRow);

            AddMenuList(ContentGrid);
            AddMinorUpdateRow(ContentGrid);

            ShadowPanel.Content = ContentGrid;
            container.Children.Add(ShadowPanel);
        }

        private void AddMenuList(Panel moduleMenu)
        {
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
            MainPageMenu.SelectionChanged += NavButton_Click;

            Binding modulesMenuBinding = new Binding
            {
                Source = ApplicationBase.Current.AppUIModules,
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            BindingOperations.SetBinding(MainPageMenu, ListView.ItemsSourceProperty, modulesMenuBinding);

            mainPageMenu = MainPageMenu;
            moduleMenu.Children.Add(MainPageMenu);
        }

        private void AddMinorUpdateRow(Panel moduleMenu)
        {
            RelativePanel MinorUpdatePanel = new RelativePanel();
            Grid.SetRow(MinorUpdatePanel, 1);

            DropShadowPanel MinorUpdateShadow = new DropShadowPanel
            {
                Style = ApplicationBase.Current.Resources["ShadowContent"] as Style,
                HorizontalContentAlignment = HorizontalAlignment.Stretch,
                VerticalContentAlignment = VerticalAlignment.Stretch
            };
            RelativePanel.SetAlignTopWithPanel(MinorUpdateShadow, true);
            RelativePanel.SetAlignBottomWithPanel(MinorUpdateShadow, true);
            RelativePanel.SetAlignRightWithPanel(MinorUpdateShadow, true);
            RelativePanel.SetAlignLeftWithPanel(MinorUpdateShadow, true);

            Grid MinorUpdateContent = new Grid
            {
                Style = ApplicationBase.Current.Resources["ContentGrid"] as Style,
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
                Margin = new Thickness(0, 0, 10, 0)
            };

            Binding minorUpdateCloseBinding = new Binding
            {
                Source = (DataContext as MainPageVMBase).CloseMinor
            };
            BindingOperations.SetBinding(MinorUpdateClose, Button.CommandProperty, minorUpdateCloseBinding);

            TextBlock MinorUpdateText = new TextBlock
            {
                Text = "Your app has been udpated to version " + (DataContext as MainPageVMBase).CurrentVersion,
                Margin = new Thickness(10, 10, 50, 10),
                VerticalAlignment = VerticalAlignment.Center
            };

            MinorUpdateContent.Children.Add(MinorUpdateClose);
            MinorUpdateContent.Children.Add(MinorUpdateText);
            MinorUpdateShadow.Content = MinorUpdateContent;
            MinorUpdatePanel.Children.Add(MinorUpdateShadow);

            moduleMenu.Children.Add(MinorUpdatePanel);
        }

        /// <summary>
        /// Prepare connected animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void NavButton_Click(object sender, SelectionChangedEventArgs e)
        {
            //var ButtonName = (sender as Button).Name;
            //TextBlock ButtonText = FindName(ButtonName.Substring(0, ButtonName.Length - 6) + "Text") as TextBlock;

            //ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("header", ButtonText);
            //((MainPageViewModel)DataContext).NavigatedPage = ButtonText.Name.Substring(0, ButtonText.Name.Length - 4);
            //((MainPageVMBase)DataContext).GoToPage();
        }

        /// <summary>
        /// Prepare connected animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GoToSettings(object sender, RoutedEventArgs e)
        {
            //var ButtonName = (sender as Button).Name;
            //TextBlock ButtonText = FindName(ButtonName.Substring(0, ButtonName.Length - 6) + "Text") as TextBlock;

            //ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("header", ButtonText);
            //((MainPageViewModel)DataContext).NavigatedPage = ButtonText.Name.Substring(0, ButtonText.Name.Length - 4);
            var settingsPageType = ApplicationBase.Current.SettingsPageType;

            if (settingsPageType != null)
                ((MainPageVMBase)DataContext).GoToPage(settingsPageType);
        }
    }
}
