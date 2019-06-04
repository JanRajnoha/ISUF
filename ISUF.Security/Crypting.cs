using System;

namespace ISUF.Security
{
    /// <summary>
    /// Crypting class
    /// </summary>
    public class Crypting
    {
        /// <summary>
        /// Decrypt message
        /// Version: 1.0
        /// </summary>
        /// <param name="Message">Encrypted message</param>
        /// <returns>Decrypted message</returns>
        public static string Decrypt(string message)
        {
            string result = "";

            if (message != null && message.Length != 0)
            {
                int offset = message[0];

                foreach (string ccns in message.Substring(1, message.Length - 1).Split((char)(offset + 10)))
                {
                    int n = 0;

                    foreach (char ccn in ccns)
                    {
                        int cn = ccn;

                        n = 10 * n + (cn - offset);
                    }

                    if (n != 0)
                    {
                        result += (char)n;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Encrypt message
        /// Version: 1.0
        /// </summary>
        /// <param name="Message">Plain string</param>
        /// <returns>Encrypted string</returns>
        public static string Encrypt(string message)
        {
            string result = "";

            if (message != null)
            {
                int offset = (new Random()).Next(170, 751);
                result += (char)offset;

                foreach (char c in message)
                {
                    int OrdVal = c;

                    foreach (char cn in OrdVal.ToString())
                    {
                        int.TryParse(cn.ToString(), out int ccn);

                        result += (char)(ccn + offset);
                    }

                    result += (char)(offset + 10);
                }
            }

            return result;
        }
    }
}
