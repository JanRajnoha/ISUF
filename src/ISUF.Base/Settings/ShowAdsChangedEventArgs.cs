using System;

namespace ISUF.Base.Settings
{
    public class ShowAdsChangedEventArgs : EventArgs
    {
        public bool ShowAdsChangedOldState { get; set; }
        public bool ShowAdsChangedNewState { get; set; }
    }
}
