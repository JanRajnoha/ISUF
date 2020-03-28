using System;
using Template10.Common;
using Template10.Utils;
using Windows.UI.Xaml;

namespace ISUF.Base.Service
{
    /// <summary>
    /// Class for getting settings from file
    /// </summary>
    public class SettingsService
    {
        public static SettingsService Instance { get; } = new SettingsService();
        Template10.Services.SettingsService.ISettingsHelper _helper;

        private SettingsService()
        {
            _helper = new Template10.Services.SettingsService.SettingsHelper();
        }

        public ApplicationTheme SystemTheme { get; set; }

        public bool UseShellBackButton
        {
            get { return _helper.Read<bool>(nameof(UseShellBackButton), true); }
            set
            {
                _helper.Write(nameof(UseShellBackButton), value);
                BootStrapper.Current.NavigationService.Dispatcher.Dispatch(() =>
                {
                    BootStrapper.Current.ShowShellBackButton = value;
                    BootStrapper.Current.UpdateShellBackButton();
                    BootStrapper.Current.NavigationService.Refresh();
                });
            }
        }

        public ApplicationTheme AppTheme
        {
            get
            {
                var theme = ApplicationTheme.Light;
                var value = _helper.Read<string>(nameof(AppTheme), theme.ToString());
                return System.Enum.TryParse<ApplicationTheme>(value, out theme) ? theme : ApplicationTheme.Dark;
            }
            set
            {
                _helper.Write(nameof(AppTheme), value.ToString());
                if (Window.Current != null)
                    (Window.Current.Content as FrameworkElement).RequestedTheme = value.ToElementTheme();
                //Views.Shell.HamburgerMenu.RefreshStyles(value);
            }
        }

        public bool UseSystemAppTheme
        {
            get => _helper.Read<bool>(nameof(UseSystemAppTheme), true);
            set => _helper.Write(nameof(UseSystemAppTheme), value);
        }

        public bool MainPageInBackStack
        {
            get => _helper.Read<bool>(nameof(MainPageInBackStack), true);
            set => _helper.Write(nameof(MainPageInBackStack), value);
        }

        //public bool SaveTemporaryNewItemCompData
        //{
        //    get => _helper.Read<bool>(nameof(SaveTemporaryNewItemCompData), true);
        //    set => _helper.Write(nameof(SaveTemporaryNewItemCompData), value);
        //}

        public bool ShowPanelAfterLeavePage
        {
            get => _helper.Read<bool>(nameof(ShowPanelAfterLeavePage), true);
            set => _helper.Write(nameof(ShowPanelAfterLeavePage), value);
        }

        //public bool AddMoreItem
        //{
        //    get => _helper.Read<bool>(nameof(AddMoreItem), true);
        //    set => _helper.Write(nameof(AddMoreItem), value);
        //}

        public bool ShowMoreInfo
        {
            get => _helper.Read<bool>(nameof(ShowMoreInfo), false);
            set => _helper.Write(nameof(ShowMoreInfo), value);
        }

        public bool ShowSmallerNotes
        {
            get => _helper.Read<bool>(nameof(ShowSmallerNotes), false);
            set => _helper.Write(nameof(ShowSmallerNotes), value);
        }

        public bool ShowLongerTitle
        {
            get => _helper.Read<bool>(nameof(ShowLongerTitle), true);
            set => _helper.Write(nameof(ShowLongerTitle), value);
        }

        public bool UseSlidableItems
        {
            get => _helper.Read<bool>(nameof(UseSlidableItems), true);
            set => _helper.Write(nameof(UseSlidableItems), value);
        }

        public bool UseBiggerButtons
        {
            get => _helper.Read<bool>(nameof(UseBiggerButtons), true);
            set => _helper.Write(nameof(UseBiggerButtons), value);
        }

        public bool UseHelloSecurity
        {
            get => _helper.Read<bool>(nameof(UseHelloSecurity), true);
            set => _helper.Write(nameof(UseHelloSecurity), value);
        }

        public bool ActivateAdBlocker
        {
            get => _helper.Read<bool>(nameof(ActivateAdBlocker), true);
            set => _helper.Write(nameof(ActivateAdBlocker), value);
        }

        public bool ActivateBackupItems
        {
            get => _helper.Read<bool>(nameof(ActivateBackupItems), true);
            set => _helper.Write(nameof(ActivateBackupItems), value);
        }

        public bool ActivateBackupItemsType
        {
            get => _helper.Read<bool>(nameof(ActivateBackupItemsType), true);
            set => _helper.Write(nameof(ActivateBackupItemsType), value);
        }

        public bool ActivateBackupItemsInterval
        {
            get => _helper.Read<bool>(nameof(ActivateBackupItemsInterval), true);
            set => _helper.Write(nameof(ActivateBackupItemsInterval), value);
        }

        public bool ActivateShareItems
        {
            get => _helper.Read<bool>(nameof(ActivateShareItems), true);
            set => _helper.Write(nameof(ActivateShareItems), value);
        }

        public bool ActivateActionCenterControl
        {
            get => _helper.Read<bool>(nameof(ActivateActionCenterControl), true);
            set => _helper.Write(nameof(ActivateActionCenterControl), value);
        }

        public bool ActivateSecondaryItemTiles
        {
            get => _helper.Read<bool>(nameof(ActivateSecondaryItemTiles), true);
            set => _helper.Write(nameof(ActivateSecondaryItemTiles), value);
        }

        public bool ActivateCustomSecuredNotificationInfo
        {
            get => _helper.Read<bool>(nameof(ActivateCustomSecuredNotificationInfo), true);
            set => _helper.Write(nameof(ActivateCustomSecuredNotificationInfo), value);
        }

        public string CustomSecuredNotificationInfoText
        {
            get => _helper.Read<string>(nameof(CustomSecuredNotificationInfoText), "");
            set => _helper.Write(nameof(CustomSecuredNotificationInfoText), value);
        }

        public TimeSpan CacheMaxDuration
        {
            get { return _helper.Read<TimeSpan>(nameof(CacheMaxDuration), TimeSpan.FromDays(2)); }
            set
            {
                _helper.Write(nameof(CacheMaxDuration), value);
                BootStrapper.Current.CacheMaxDuration = value;
            }
        }

        public string CurrentAppVersion
        {
            get => _helper.Read(nameof(CurrentAppVersion), "0.0.0");
            set
            {
                while (_helper.Read(nameof(CurrentAppVersion), "0.0.0") != value)
                {
                    _helper.Write(nameof(CurrentAppVersion), value);
                }
            }
        }

        public ApplicationTheme GetTheme()
        {
            return ApplicationTheme.Dark;
        }
    }
}
