using ISUF.UI.Classes;
using ISUF.UI.Modules;
using ISUF.UI.XamlStyles;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Template10.Common;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ISUF.UI.App
{
    [Bindable]
    public abstract class AppClass : BootStrapper
    {
        public new static AppClass Current { get; set; }

        public VMLocator VMLocator { get; set; } = new VMLocator();

        public UIModuleManager ModuleManager { get; set; }

        public AppClass()
        {
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
        protected virtual void OnSuspending(object sender, Windows.ApplicationModel.SuspendingEventArgs e)
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

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected virtual void OnLaunched(LaunchActivatedEventArgs e)
        { }
    }
}
