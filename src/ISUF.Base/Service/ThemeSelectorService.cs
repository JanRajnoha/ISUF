using ISUF.Base.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;

namespace ISUF.Base.Service
{
    public static class ThemeSelectorService
    {
        public static event EventHandler<AppTheme> OnThemeChanged = (sender, args) => { };

        public static AppTheme Theme { get; set; } = AppTheme.System;

        /// <summary>
        /// Set default theme from settings
        /// </summary>
        public static void Initialize()
        {
            Theme = LoadThemeFromSettings();
        }

        /// <summary>
        /// Set selected theme
        /// </summary>
        /// <param name="theme">Selected theme</param>
        public static void SetTheme(AppTheme theme)
        {
            Theme = theme;

            SetRequestedTheme();
            SaveThemeInSettings(Theme);

            OnThemeChanged(null, Theme);
        }

        /// <summary>
        /// Set requested theme
        /// </summary>
        public static void SetRequestedTheme()
        {
            if (Window.Current?.Content is FrameworkElement frameworkElement)
            {
                if (!SettingsService.Instance.UseSystemAppTheme)
                {
                    ElementTheme trueTheme;

                    trueTheme = (ElementTheme)Theme;

                    if (frameworkElement.RequestedTheme == ElementTheme.Dark)
                    {
                        frameworkElement.RequestedTheme = ElementTheme.Light;
                    }

                    frameworkElement.RequestedTheme = trueTheme;
                }
                else
                    if ((new UISettings().GetColorValue(UIColorType.Background)).R == 0)
                    frameworkElement.RequestedTheme = ElementTheme.Dark;
                else
                    frameworkElement.RequestedTheme = ElementTheme.Light;
            }
        }

        /// <summary>
        /// Load theme from file
        /// </summary>
        /// <returns>Loaded theme</returns>
        private static AppTheme LoadThemeFromSettings()
        {
            AppTheme cacheTheme = AppTheme.System;

            if (!SettingsService.Instance.UseSystemAppTheme)
                cacheTheme = (AppTheme)SettingsService.Instance.AppTheme;
            else
                cacheTheme = (AppTheme)SettingsService.Instance.SystemTheme;

            return cacheTheme;
        }

        /// <summary>
        /// Save theme in settings
        /// </summary>
        /// <param name="theme">Saved theme</param>
        private static void SaveThemeInSettings(AppTheme theme)
        {
            if (!SettingsService.Instance.UseSystemAppTheme)
                SettingsService.Instance.AppTheme = (ApplicationTheme)theme;
        }
    }
}

