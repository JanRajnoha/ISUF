using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Security
{
    public static class SecureSign
    {
        private static (byte[] Salt, byte[] Hash) GetHash(string pass, byte[] salt = null)
        {
            byte[] saltByte;

            if (salt == null)
            {
                saltByte = new byte[8];
                using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
                    rngCsp.GetBytes(saltByte);
            }
            else
                saltByte = salt;

            Rfc2898DeriveBytes hash = new Rfc2898DeriveBytes(pass, saltByte);
            hash.Reset();
            return (saltByte, hash.GetBytes(256));
        }

        public static bool Decrypt(byte[] salt, byte[] hash, string pass) => Enumerable.SequenceEqual(GetHash(pass, salt).Hash, hash);

        public static (byte[] Salt, byte[] Hash) Encrypt(string pass) => GetHash(pass);
    }
}
