using System;
using System.Linq;
using ISUF.Interface.Storage;
using ISUF.Storage.Templates;

namespace ISUF.Storage.Manager
{
    /// <summary>
    /// User item manager
    /// </summary>
    public class UserItemManager : AtomicItemManager
    {
        /// <summary>
        /// Init for user module
        /// </summary>
        /// <param name="dbAccess">Database access</param>
        /// <param name="moduleItemType">Item type</param>
        /// <param name="moduleName">Module name</param>
        public UserItemManager(IDatabaseAccess dbAccess, Type moduleItemType, string moduleName) : base(dbAccess, moduleItemType, moduleName)
        {
        }

        /// <summary>
        /// Get users
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="username">Username</param>
        /// <returns>Usernames which contains username</returns>
        public T GetUserByUsername<T>(string username) where T : UserItem
        {
            var user = dbAccess.GetAllItems<T>().Where(x => x.Username == username).FirstOrDefault();

            return user;
        }
    }
}
