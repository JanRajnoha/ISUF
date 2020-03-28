using System;

namespace ISUF.Base.Settings
{
    /// <summary>
    /// Args for UserLoggedEventArgs
    /// </summary>
    public class UserLoggedEventArgs : EventArgs
    {
        /// <summary>
        /// Old state 
        /// </summary>
        public bool UserLoggedOldState { get; set; }

        /// <summary>
        /// New state
        /// </summary>
        public bool UserLoggedNewState { get; set; }
    }
}
