using ISUF.Base.Enum;
using ISUF.Base.Service;
using ISUF.Base.Settings;
using ISUF.Interface.UI;
using ISUF.UI.App;
using ISUF.UI.Classes;
using ISUF.UI.Modules;
using System;
using System.Globalization;
using System.Linq;
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
    /// <summary>
    /// Base for shell of app
    /// </summary>
    public class ShellBase : Page, IPageBase
    {
        const string MSAProviderId = "https://login.microsoft.com";
        const string ConsumerAuthority = "consumers";
        const string AccountScopeRequested = "wl.basic";
        const string AccountClientId = "none";
        const string StoredAccountKey = "accountid";
        const string StoredAccountProviderKey = "accountProviderid";
        readonly string appDisplayName;
        readonly Type settingsPageType;
        readonly Type mainPageType;
        Controls.NavigationView navView;
        TextBlock appTitle;

        private readonly UISettings uiSettings = new UISettings();
        public static ShellBase Instance { get; set; }
        public static HamburgerMenu HamburgerMenu => Instance.HamMen;
        public HamburgerMenu HamMen { get; set; }

        /// <summary>
        /// Set navigation service which is gived by argument
        /// </summary>
        /// <param name="navigationService">New navigation service</param>
        public ShellBase(string appDisplayName, Type mainPageType, Type settingsPageType, INavigationService navigationService)
        {
            if (navigationService == null)
                throw new ArgumentNullException(nameof(navigationService), "Navigation service couldn't be null.");

            this.appDisplayName = appDisplayName;
            this.settingsPageType = settingsPageType;
            this.mainPageType = mainPageType ?? throw new ArgumentNullException(nameof(mainPageType), "Type for Main page couldn't be null.");

            Instance = this;

            HamMen = new HamburgerMenu();

            SetNavigationService(ApplicationBase.Current.NavigationService);

            CustomSettings.ShowAdsChanged -= CustomSettings_ShowAdsChanged;
            CustomSettings.ShowAdsChanged += CustomSettings_ShowAdsChanged;

            CoreApplicationViewTitleBar titleBar = CoreApplication.GetCurrentView().TitleBar;

            titleBar.LayoutMetricsChanged -= TitleBar_LayoutMetricsChanged;
            titleBar.LayoutMetricsChanged += TitleBar_LayoutMetricsChanged;

            uiSettings.ColorValuesChanged += ThemeChanger;

            SetNavigationService(navigationService);

            Loading += ShellBase_Loading;
        }

        /// <summary>
        /// Shell loading event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected virtual void ShellBase_Loading(FrameworkElement sender, object args)
        {
            AddControls();
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
        /// Set current selected item from NavView
        /// </summary>
        /// <param name="tag">Tag of item</param>
        public void SetSelectedNavItem(object tag)
        {
            if (tag is string && tag != null && (tag as string).ToLower().Contains("settings"))
                navView.SelectedItem = navView.SettingsItem;
            else
            {
                navView.SelectedItem = navView.MenuItems.FirstOrDefault(x =>
                {
                    if (x is NavigationViewItem NavItem)
                        if (NavItem.Tag == tag)
                            return true;

                    return false;
                });
            }
        }

        /// <summary>
        /// Change theme to system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ThemeChanger(UISettings sender, object args)
        {
            if (SettingsService.Instance.UseSystemAppTheme)
            {
                ThemeSelectorService.SetTheme(AppTheme.Dark);
            }
        }

        /// <summary>
        /// Make space for back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void TitleBar_LayoutMetricsChanged(CoreApplicationViewTitleBar sender, object args)
        {
            if (appTitle == null)
            {
                return;
            }
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
            if (navView == null)
            {
                return;
            }

            navView.ShowAd = !e.ShowAdsChangedNewState ? Visibility.Visible : Visibility.Collapsed;
        }

        /// <summary>
        /// Add controls into shell
        /// </summary>
        public void AddControls()
        {
            Grid Container = new Grid();

            Controls.NavigationView NavView = new Controls.NavigationView
            {
                Name = nameof(NavView),
                ShowAd = Visibility.Collapsed,
                AlwaysShowHeader = false,
                IsSettingsVisible = settingsPageType != null,
                CompactModeThresholdWidth = Application.Current.Resources["NormalMinWidth"] as double? ?? 0,
                ExpandedModeThresholdWidth = Application.Current.Resources["WideMinWidth"] as double? ?? 0
            };
            NavView.Loaded += NavView_Loaded;
            NavView.ItemInvoked += NavView_ItemInvoked;
            NavView.SelectionChanged += NavView_SelectionChanged;

            NavigationViewItem navHomeItem = new NavigationViewItem
            {
                Content = "Home",
                Tag = "home",
                Icon = new SymbolIcon(Symbol.Home)
            };
            NavView.MenuItems.Add(navHomeItem);

            foreach (var navItem in ApplicationBase.Current.AppUIModules)
            {
                NavView.MenuItems.Add(CreateNavigationItem(navItem));
            }
            
            string navViewHeaderTemplate = "<DataTemplate xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\">" +
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

            Content = Container;
        }

        /// <summary>
        /// Crate navigation item
        /// </summary>
        /// <param name="appModuleItem">App module item</param>
        /// <returns>Navigation item</returns>
        private object CreateNavigationItem(AppModuleItem appModuleItem)
        {
            NavigationViewItem navItem = new NavigationViewItem
            {
                Content = appModuleItem.ModuleDisplayName,
                Tag = appModuleItem.ModulePage,
                Icon = new SymbolIcon(appModuleItem.ModuleDisplayIcon)
            };

            return navItem;
        }

        /// <summary>
        /// Navigationview selection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            // Is it really needed?
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
                    && navView.MenuItems.FirstOrDefault(x => ((x as NavigationViewItem).Content as string) == itemText) is NavigationViewItem navItem)
                {
                    if (navItem.Tag is Type modulePageType)
                    {
                        HamMen.NavigationService.Navigate(modulePageType, infoOverride: new SuppressNavigationTransitionInfo());
                    }
                    else
                    {
                        HamMen.NavigationService.Navigate(mainPageType, infoOverride: new SuppressNavigationTransitionInfo());
                    }
                }
            }
        }

        /// <summary>
        /// Set frame for navigating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            if (HamMen.NavigationService == null)
            {
                return;
            }

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
