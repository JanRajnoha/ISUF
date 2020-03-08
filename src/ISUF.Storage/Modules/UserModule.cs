using ISUF.Base.Modules;
using ISUF.Security;
using ISUF.Storage.Enum;
using ISUF.Storage.Manager;
using ISUF.Storage.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Modules
{
    public class UserModule : StorageModule
    {
        //public int CurrentUserSession { get; private set; }
        public int CurrentUserId { get; private set; } = -1;

        public UserModule(Type moduleItemType, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, itemManagerType, moduleTableName)
        {
        }

        public UserModule(Type moduleItemType, string moduleName, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, moduleName, itemManagerType, moduleTableName)
        {
        }

        public bool SignInUser(string username, string password)
        {
            var user = ((UserItemManager)itemManager).GetUserByUsername<UserItem>(username);

            if (SecureSign.Decrypt(user.Salt, user.Hash, password))
            {
                CurrentUserId = user.Id;
                //CrateUserSession();

                LogUserActivity(UserLogType.SignIn, CurrentUserId);
            }
            else
            {
                LogUserActivity(UserLogType.AccessDenied, CurrentUserId);
                return false;
            }

            return true;
        }

        private void LogUserActivity(UserLogType logType, int currentUserId)
        {
            var userActivityLogItem = new LogUserActivityItem()
            {
                UserActivity = logType,
                UserId = currentUserId
            };

            ((LogUserModule)moduleManager.GetModule(typeof(LogUserModule))).LogUserActivity(userActivityLogItem);
        }

        public bool RegisterUser(UserItem newUser)
        {
            if (!((UserItemManager)itemManager).AddItem(newUser, moduleManager))
                return false;
            
            CurrentUserId = newUser.Id;
            //CrateUserSession();
            LogUserActivity(UserLogType.Register, CurrentUserId);

            return true;
        }

        public void SignOutUser()
        {
            LogUserActivity(UserLogType.SignOut, CurrentUserId);
            CurrentUserId = -1;
        }

        public int GetCurrentUserId()
        {
            return CurrentUserId;
        }


        //private void CrateUserSession()
        //{
        //    var user = ItemManager.GetItem<UserItem>(CurrentUserId);

        //    DateTime ss = new DateTime(123456);

        //    string hashString = $"{user.Username};{Environment.MachineName};{Environment.UserName}";

        //    CurrentUserSession = hashString.GetHashCode();
        //}
    }
}
