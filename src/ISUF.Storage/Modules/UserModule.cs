using ISUF.Security;
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
        public int CurrentUserId { get; private set; }

        public UserModule(Type moduleItemType, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, itemManagerType, moduleTableName)
        {
        }

        public UserModule(Type moduleItemType, string moduleName, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, moduleName, itemManagerType, moduleTableName)
        {
        }

        public bool SignInUser(string username, string password)
        {
            var user = ((UserItemManager)ItemManager).GetUserByUsername<UserItem>(username);

            if (SecureSign.Decrypt(user.Salt, user.Hash, password))
            {
                CurrentUserId = user.ID;
                //CrateUserSession();
            }
            else return false;

            return true;
        }

        public bool RegisterUser(string username, string password)
        {
            // toto predelat na registraci
            var user = ((UserItemManager)ItemManager).GetUserByUsername<UserItem>(username);

            CurrentUserId = user.ID;
            //CrateUserSession();

            return true;
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
