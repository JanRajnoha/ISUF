using System;

namespace ISUF.Base.Settings
{
    /// <summary>
    /// Custom Settings class
    /// </summary>
    public class CustomSettings
    {
        private static bool isUserLogged = false;

        public static bool IsUserLogged
        {
            get { return isUserLogged; }

            set
            {
                UserLoggedEventArgs args = new UserLoggedEventArgs()
                {
                    UserLoggedOldState = isUserLogged,
                    UserLoggedNewState = value
                };
                isUserLogged = value;
                UserLoggedEvent(args);
            }
        }

        static void UserLoggedEvent(UserLoggedEventArgs e)
        {
            UserLogChanged?.Invoke(null, e);
        }

        public static event EventHandler<UserLoggedEventArgs> UserLogChanged;

        //
        // -----------------------------------------------------------------------------------------------
        //

        private static bool showAds = true;

        public static bool ShowAds
        {
            get { return showAds; }

            set
            {
                ShowAdsChangedEventArgs args = new ShowAdsChangedEventArgs()
                {
                    ShowAdsChangedOldState = showAds,
                    ShowAdsChangedNewState = value
                };
                showAds = value;
                ShowAdsChangedEvent(args);
            }
        }

        static void ShowAdsChangedEvent(ShowAdsChangedEventArgs e)
        {
            ShowAdsChanged?.Invoke(null, e);
        }

        public static event EventHandler<ShowAdsChangedEventArgs> ShowAdsChanged;
    }
}
