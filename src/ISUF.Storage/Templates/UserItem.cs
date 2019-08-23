using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ISUF.Storage.Templates
{
    class UserItem : BaseItem
    {
        public string UserName { get; set; }
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }

        [XmlIgnore]
        public string Password { get; set; } = string.Empty;

        public UserItem(string userName, byte[] hash, byte[] salt)
        {
            UserName = userName;
            Hash = hash;
            Salt = salt;
        }

        public UserItem(UserItem userItem) : base(userItem)
        {
            UserName = userItem.UserName;
            Hash = userItem.Hash;
            Salt = userItem.Salt;
            Password = userItem.Password;
        }

        public override object Clone()
        {
            return new UserItem(this);
        }
    }
}
