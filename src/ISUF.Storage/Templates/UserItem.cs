﻿using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ISUF.Storage.Templates
{
    /// <summary>
    /// Model for storing user record din database
    /// </summary>
    public class UserItem : AtomicItem
    {
        public string Username { get; set; }
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }

        [XmlIgnore]
        public string Password { get; set; } = string.Empty;

        public UserItem(string username, byte[] hash, byte[] salt)
        {
            Username = username;
            Hash = hash;
            Salt = salt;
        }

        public UserItem(UserItem userItem) : base(userItem)
        {
            Username = userItem.Username;
            Hash = userItem.Hash;
            Salt = userItem.Salt;
            Password = userItem.Password;
        }

        public override object Clone()
        {
            return new UserItem(this);
        }

        public override string ToString()
        {
            return $"{Id}:  {Username}";
        }
    }
}
