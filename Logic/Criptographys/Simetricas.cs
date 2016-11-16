using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Logic.Criptographys
{
    public class Simetricas
    {
        static readonly byte[] MatrizRijndeal = { 0xf, 0x6f, 0x13, 0x2e, 0x35, 0xc2, 0xcd, 0xf9, 0x5, 0x46, 0x9c, 0xea, 0xa8, 0x4b, 0x73, 0xcc };

        static readonly byte[] MatrizDes = { 0xf, 0x6f, 0x13, 0x2e, 0x35, 0xc2, 0xcd, 0xf9 };

        public class Encript
        {
            public static string Rijndael(string text, string key)
            {
                var bytes = Encoding.UTF8.GetBytes(text);
                using (var rijndeal = new RijndaelManaged())
                {
                    using (var cryptography = rijndeal.CreateEncryptor(GetKey(rijndeal , key), MatrizRijndeal))
                    {
                        using (var memory = new MemoryStream())
                        {
                            using (var encryptor = new CryptoStream(memory, cryptography, CryptoStreamMode.Write))
                            {
                                encryptor.Write(bytes, 0, bytes.Length);
                                encryptor.FlushFinalBlock();
                                return Convert.ToBase64String(memory.ToArray(), 0, memory.ToArray().GetLength(0));
                            }
                        }
                    }
                }
            }

            public static string Des(string text, string key)
            {
                var bytes = Encoding.UTF8.GetBytes(text);
                using (var des = new DESCryptoServiceProvider())
                {
                    using (var cryptography = des.CreateEncryptor(GetKey(des, key), MatrizDes))
                    {
                        using (var memory = new MemoryStream())
                        {
                            using (var encryptor = new CryptoStream(memory, cryptography, CryptoStreamMode.Write))
                            {
                                encryptor.Write(bytes, 0, bytes.Length);
                                encryptor.FlushFinalBlock();
                                return Convert.ToBase64String(memory.ToArray(), 0, memory.ToArray().GetLength(0));
                            }
                        }
                    }
                }
            }
        }

        public class Decript
        {
            public static string Rijndael(string text, string key)
            {
                var bytes = Convert.FromBase64String(text);
                using (var rijndeal = new RijndaelManaged())
                {
                    using (var cryptography = rijndeal.CreateDecryptor(GetKey(rijndeal, key), MatrizRijndeal))
                    {
                        using (var memory = new MemoryStream(bytes, 0, bytes.Length))
                        {
                            using (var decryptor = new CryptoStream(memory, cryptography, CryptoStreamMode.Read))
                            {
                                using (var reader = new StreamReader(decryptor))
                                {
                                    return reader.ReadToEnd();
                                }
                            }
                        }
                    }
                }
            }

            public static string Des(string text, string key)
            {
                var bytes = Convert.FromBase64String(text);
                using (var des = new DESCryptoServiceProvider())
                {
                    using (var cryptography = des.CreateDecryptor(GetKey(des, key), MatrizDes))
                    {
                        using (var memory = new MemoryStream(bytes, 0, bytes.Length))
                        {
                            using (var decryptor = new CryptoStream(memory, cryptography, CryptoStreamMode.Read))
                            {
                                using (var reader = new StreamReader(decryptor))
                                {
                                    return reader.ReadToEnd();
                                }
                            }
                        }
                    }
                }
            }
        }

        public static byte[] GetKey(SymmetricAlgorithm algorithm, string key)
        {
            var salt = string.Empty;

            if (algorithm.LegalKeySizes.Length > 0)
            {
                var keySize = key.Length * 8;
                var minSize = algorithm.LegalKeySizes[0].MinSize;
                var maxSize = algorithm.LegalKeySizes[0].MaxSize;
                var skipSize = algorithm.LegalKeySizes[0].SkipSize;

                if (keySize > maxSize)
                {
                    key = key.Substring(0, maxSize / 8);
                }
                else if (keySize < maxSize)
                {
                    var validSize = (keySize <= minSize) ? minSize : (keySize - keySize % skipSize) + skipSize;
                    if (keySize < validSize)
                    {
                        key = key.PadRight(validSize / 8, '*');
                    }
                }
            }
            return new PasswordDeriveBytes(key, Encoding.UTF8.GetBytes(salt)).GetBytes(key.Length);
        }
    }

}

