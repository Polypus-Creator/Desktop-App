using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class HelperClassSecurity
    {
        public static string MD5Digest(string text)
        {
            string digest = "";
            MD5 md5 = MD5CryptoServiceProvider.Create();
            Byte[] bytes = Encoding.Default.GetBytes(text);
            Byte[] hashBytes = md5.ComputeHash(bytes);
            digest = BitConverter.ToString(hashBytes);
            digest = digest.Replace("-", String.Empty);
            return digest;
        }

        public static string Sha1Digest(string text)
        {
            string digest = "";
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] bytes = Encoding.Default.GetBytes(text);
            Byte[] hashBytes = sha1.ComputeHash(bytes);
            digest = BitConverter.ToString(hashBytes);
            digest = digest.Replace("-", String.Empty);
            return digest;
        }
    }
}
