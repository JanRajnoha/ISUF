using System;
using System.Linq;
using ISUF.Interface.Storage;
using ISUF.Storage.Templates;

namespace ISUF.Storage.Manager
{
    public class UserItemManager : ItemManager
    {
        public UserItemManager(IDatabaseAccess dbAccess, Type moduleItemType, string moduleName) : base(dbAccess, moduleItemType, moduleName)
        {
        }

        public T GetUserByUsername<T>(string username) where T : UserItem
        {
            var user = dbAccess.GetAllItems<T>().Where(x => x.Username == username).FirstOrDefault();

            return user;
        }
    }
}
