using System;

namespace ISUF.Base.Settings
{
    /// <summary>
    /// Args for UserLoggedEventArgs
    /// </summary>
    public class UserLoggedEventArgs : EventArgs
    {
        public bool UserLoggedOldState { get; set; }
        public bool UserLoggedNewState { get; set; }
    }
}
