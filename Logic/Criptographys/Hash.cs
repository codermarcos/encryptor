using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Logic.Criptographys
{
    public class Hash
    {
        public static string Md5(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                md5.ComputeHash(Encoding.ASCII.GetBytes(text));
                return md5.Hash.Aggregate(string.Empty, (current, c) => current + c.ToString("x2"));
            }
        }
        public static string Sha1(string text)
        {
            using (var sha1 = new SHA1Managed())
            {
                sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
                return sha1.Hash.Aggregate(string.Empty, (current, c) => current + c.ToString("X2"));
            }
        }
        public static string Sha512(string text)
        {
            using (var sha1 = new SHA512Managed())
            {
                sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
                return sha1.Hash.Aggregate(string.Empty, (current, c) => current + c.ToString("X2"));
            }
        }
    }
}
