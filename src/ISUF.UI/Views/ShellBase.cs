using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISUF.Base.Classes;
using ISUF.Base.Enum;
using ISUF.Base.Service;
using ISUF.Base.Settings;
using ISUF.UI.Controls;
using Template10.Controls;
using Template10.Services.NavigationService;
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;
using NavigationView = Windows.UI.Xaml.Controls.NavigationView;
//using NavigationView = ISUF.UI.Controls.NavigationView;

namespace ISUF.UI.Views
{
    public class ShellBase : PageBase
    {
        const string MSAProviderId = "https://login.microsoft.com";
        const string ConsumerAuthority = "consumers";
        const string AccountScopeRequested = "wl.basic";
        const string AccountClientId = "none";
        const string StoredAccountKey = "accountid";
        const string StoredAccountProviderKey = "accountProviderid";

        string appDisplayName;
        Type settingsPageType;
        Controls.NavigationView navView;
        TextBlock appTitle;

        private readonly UISettings uiSettings = new UISettings();
        public static ShellBase Instance { get; set; }
        public static HamburgerMenu HamburgerMenu => Instance.HamMen;
        public HamburgerMenu HamMen { get; set; }

        public ShellBase(string appDisplayName, Type settingsPageType)
        {
            this.appDisplayName = appDisplayName;
            this.settingsPageType = settingsPageType;

            Instance = this;

            HamMen = new HamburgerMenu();

            CustomSettings.ShowAdsChanged -= CustomSettings_ShowAdsChanged;
            CustomSettings.ShowAdsChanged += CustomSettings_ShowAdsChanged;

            CoreApplicationViewTitleBar titleBar = CoreApplication.GetCurrentView().TitleBar;

            titleBar.LayoutMetricsChanged -= TitleBar_LayoutMetricsChanged;
            titleBar.LayoutMetricsChanged += TitleBar_LayoutMetricsChanged;

            uiSettings.ColorValuesChanged += ThemeChanger;
        }

        /// <summary>
        /// Set navigation service which is gived by argument
        /// </summary>
        /// <param name="navigationService">New navigation service</param>
        public ShellBase(string appDisplayName, Type settingsPageType, INavigationService navigationService) : this(appDisplayName, settingsPageType)
        {
            SetNavigationService(navigationService);
        }

        /// <summary>
        /// Set Navigation Service
        /// </summary>
        /// <param name="navigationService"></param>
        public void SetNavigationService(INavigationService navigationService)
        {
            HamMen.NavigationService = navigationService;
        }

        /// <summary>
        /// Change theme to system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ThemeChanger(UISettings sender, object args)
        {
            if (SettingsService.Instance.UseSystemAppTheme)
                ThemeSelectorService.SetTheme(AppTheme.Dark);
        }

        /// <summary>
        /// Make space for back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void TitleBar_LayoutMetricsChanged(CoreApplicationViewTitleBar sender, object args)
        {
            if (appTitle == null) return;
            //AppTitle.Margin = new Thickness(CoreApplication.GetCurrentView().TitleBar.SystemOverlayLeftInset + 12, 8, 0, 0);
            appTitle.Margin = new Thickness(0, 8, 0, 0);
        }

        /// <summary>
        /// Change visibility of ad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomSettings_ShowAdsChanged(object sender, ShowAdsChangedEventArgs e)
        {
            if (navView == null) return;
            navView.ShowAd = !e.ShowAdsChangedNewState ? Visibility.Visible : Visibility.Collapsed;
        }

        public override void AddControls()
        {
            Grid Container = new Grid();

            Controls.NavigationView NavView = new Controls.NavigationView
            {
                ShowAd = Visibility.Collapsed,
                AlwaysShowHeader = false,
                CompactModeThresholdWidth = Application.Current.Resources["NormalMinWidth"] as double? ?? 0,
                ExpandedModeThresholdWidth = Application.Current.Resources["WideMinWidth"] as double? ?? 0
            };
            NavView.Loaded += NavView_Loaded;
            NavView.ItemInvoked += NavView_ItemInvoked;
            NavView.SelectionChanged += NavView_SelectionChanged;

            NavView.MenuItems.Add(CreateNavigationItem("Home", Symbol.Home));

            var navViewHeaderTemplate = "<DataTemplate xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\">" +
                "<Grid Background=\"{ThemeResource SystemControlAcrylicWindowMediumHighBrush}\" Height=\"32\">" +
                "</Grid>" +
                "</DataTemplate>";
            NavView.HeaderTemplate = (DataTemplate)XamlReader.Load(navViewHeaderTemplate);

            //NavigationViewItem Login

            //NavView.PaneFooter

            NavigationThemeTransition navThemeTransition = new NavigationThemeTransition();

            Frame ContentFrame = new Frame();
            ContentFrame.ContentTransitions.Add(navThemeTransition);

            NavView.Content = ContentFrame;

            TextBlock AppTitle = new TextBlock
            {
                Style = Application.Current.Resources["CaptionTextBlockStyle"] as Style,
                Text = appDisplayName,
                IsHitTestVisible = false,
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Center,
                Visibility = Visibility.Visible,
                Height = 15
            };

            Container.Children.Add(NavView);
            Container.Children.Add(AppTitle);

            navView = NavView;
            appTitle = AppTitle;
        }

        private object CreateNavigationItem(string itemTitle, Symbol itemIcon)
        {
            NavigationViewItem navItem = new NavigationViewItem
            {
                Content = itemTitle,
                Tag = itemTitle.ToLower(CultureInfo.CurrentUICulture),
                Icon = new SymbolIcon(itemIcon)
            };

            return navItem;
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            // It is really needed?
        }

        /// <summary>
        /// Navigationm from shell menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                HamMen.NavigationService.Navigate(settingsPageType);
            }
            else
            {
                if (args.InvokedItem is string itemText
                    && navView.MenuItems.FirstOrDefault(x => ((x as NavigationViewItem).Content as string) == itemText) is NavigationViewItem navItem
                    && navItem.Tag is Type modulePageType)

                    HamMen.NavigationService.Navigate(modulePageType);
            }
        }

        /// <summary>
        /// Set frame for navigating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            navView.Content = HamMen.NavigationService.FrameFacade.Frame;

            foreach (NavigationViewItem item in navView.MenuItems)
            {
                if (item.Tag.ToString() == "home")
                {
                    navView.SelectedItem = item;
                    break;
                }
            }
        }
    }
}
