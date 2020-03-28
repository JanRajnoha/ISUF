using System;

namespace ISUF.Base.Settings
{
    /// <summary>
    /// Custom Settings class
    /// </summary>
    public static class CustomSettings
    {
        private static bool isUserLogged = false;

        /// <summary>
        /// Switch for logged user
        /// </summary>
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

        /// <summary>
        /// User logged event
        /// </summary>
        /// <param name="e"></param>
        private static void UserLoggedEvent(UserLoggedEventArgs e)
        {
            UserLogChanged?.Invoke(null, e);
        }

        /// <summary>
        /// User logged event
        /// </summary>
        public static event EventHandler<UserLoggedEventArgs> UserLogChanged;

        //
        // -----------------------------------------------------------------------------------------------
        //

        private static bool showAds = true;

        /// <summary>
        /// Switch for showing ads
        /// </summary>
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

        /// <summary>
        /// Show ads changed event
        /// </summary>
        /// <param name="e"></param>
        private static void ShowAdsChangedEvent(ShowAdsChangedEventArgs e)
        {
            ShowAdsChanged?.Invoke(null, e);
        }

        /// <summary>
        /// Show ads changed
        /// </summary>
        public static event EventHandler<ShowAdsChangedEventArgs> ShowAdsChanged;
    }
}
