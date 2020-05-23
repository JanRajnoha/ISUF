using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Security
{
    /// <summary>
    /// Class for securing password and checking 
    /// </summary>
    public static class SecureSign
    {
        /// <summary>
        /// Get hash from password and optionally from combination with salt
        /// </summary>
        /// <param name="pass">Inserted password</param>
        /// <param name="salt">Optional salt</param>
        /// <returns>Tuple of salt and hash</returns>
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

        /// <summary>
        /// Check if inserted password is equalt to hash and salt
        /// </summary>
        /// <param name="salt">Inserted salt</param>
        /// <param name="hash">Inserted hash</param>
        /// <param name="pass">Inserted password</param>
        /// <returns>Check of compare</returns>
        public static bool Decrypt(byte[] salt, byte[] hash, string pass) => Enumerable.SequenceEqual(GetHash(pass, salt).Hash, hash);

        /// <summary>
        /// Encrypt password into hash and salt
        /// </summary>
        /// <param name="pass">Inserted password</param>
        /// <returns>Tuple of salt and hash</returns>
        public static (byte[] Salt, byte[] Hash) Encrypt(string pass) => GetHash(pass);
    }
}
