using ISUF.Base.Classes;
using ISUF.UI.Classes;
using ISUF.UI.Controls;
using ISUF.UI.Modules;
using ISUF.UI.XamlStyles;

using System;
using System.Threading.Tasks;

using Template10.Common;
using Template10.Controls;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ISUF.UI.App
{
    [Bindable]
    public abstract class ApplicationBase : BootStrapper
    {
        Type settingsPageType;

        public new static ApplicationBase Current { get; set; }

        public VMLocator VMLocator { get; set; } = new VMLocator();

        public UIModuleManager ModuleManager { get; set; }

        public ApplicationBase(Type settingsPageType)
        {
            this.settingsPageType = settingsPageType;
            Suspending += OnSuspending;
        }

        public object ImportResources()
        {
            var customResources = (ResourceDictionary)XamlReader.Load(XamlDictionaries.Colors);
            customResources.MergedDictionaries.Add((ResourceDictionary)XamlReader.Load(XamlDictionaries.Controls));

            return customResources;
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        protected virtual void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e?.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

        public override abstract Task OnStartAsync(StartKind startKind, IActivatedEventArgs args);

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        protected virtual void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e?.SourcePageType.FullName);
        }

        public override async Task OnInitializeAsync(IActivatedEventArgs args)
        {
            //draw into the title bar
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;

            //remove the solid-colored backgrounds behind the caption controls and system back button
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;

            SolidColorBrush btnForegroundColor = Current.Resources["TitleBarForegroundThemeBrush"] as SolidColorBrush;
            SolidColorBrush btnBackgroundHoverColor = Current.Resources["TitleBarPressedBackgroundThemeBrush"] as SolidColorBrush;
            SolidColorBrush btnHoverColor = Current.Resources["TitleBarButtonHoverThemeBrush"] as SolidColorBrush;
            SolidColorBrush btnBackgroundPressedColor = Current.Resources["TitleBarHoverBackgroundThemeBrush"] as SolidColorBrush;
            SolidColorBrush btnPressedColor = Current.Resources["TitleBarButtonPressedThemeBrush"] as SolidColorBrush;

            titleBar.BackgroundColor = Colors.Transparent;
            titleBar.ForegroundColor = btnForegroundColor.Color;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonForegroundColor = btnForegroundColor.Color;
            titleBar.ButtonHoverBackgroundColor = btnBackgroundHoverColor.Color;
            titleBar.ButtonHoverForegroundColor = btnHoverColor.Color;
            titleBar.ButtonPressedBackgroundColor = btnBackgroundPressedColor.Color;
            titleBar.ButtonPressedForegroundColor = btnPressedColor.Color;
            titleBar.InactiveBackgroundColor = Colors.Transparent;
            titleBar.InactiveForegroundColor = btnForegroundColor.Color;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveForegroundColor = btnForegroundColor.Color;

            if (Window.Current.Content as ModalDialog == null)
            {
                // create a new frame 
                var nav = NavigationServiceFactory(BackButton.Attach, ExistingContent.Include);

                // create modal root
                Window.Current.Content = new ModalDialog
                {
                    DisableBackButtonWhenModal = true,
                    Content = new Views.ShellBase(Package.Current.DisplayName + (Constants.Instance.BetaMode ? " - Beta version" : ""), settingsPageType, nav),
                    ModalContent = new Busy(),
                };
            }
            await Task.CompletedTask;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected virtual void OnLaunched(LaunchActivatedEventArgs e)
        { }
    }
}
