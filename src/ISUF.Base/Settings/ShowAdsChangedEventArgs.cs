using System;

namespace ISUF.Base.Settings
{
    /// <summary>
    /// Event arguments for ShowAdsChangedEvent
    /// </summary>
    public class ShowAdsChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Old state
        /// </summary>
        public bool ShowAdsChangedOldState { get; set; }

        /// <summary>
        /// New state
        /// </summary>
        public bool ShowAdsChangedNewState { get; set; }
    }
}
