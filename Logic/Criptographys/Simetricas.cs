
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Logic.Criptographys
{
    public class Simetricas
    {
        public class Encript
        {
            public static string Rijndael(string text, string key)
            {
                using (var rijndael = GetRijndael(key, "JWEIGJF23JGIFJ3I"))
                {
                    using (var encryptor = rijndael.CreateEncryptor(rijndael.Key, rijndael.IV))
                    {
                        using (var memory = new MemoryStream())
                        {
                            using (var stream = new CryptoStream(memory, encryptor, CryptoStreamMode.Write))
                            {
                                using (var writer = new StreamWriter(stream))
                                {
                                    writer.Write(text);
                                }
                                return Functions.BytesToHex(memory.ToArray());
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
                using (var rijndael = GetRijndael(key, "JWEIGJF23JGIFJ3I"))
                {
                    using (var decryptor = rijndael.CreateDecryptor(rijndael.Key, rijndael.IV))
                    {
                        using (var memory = new MemoryStream(Functions.HexToBytes(text)))
                        {
                            using (var stream = new CryptoStream(memory, decryptor, CryptoStreamMode.Read))
                            {
                                using (var reader = new StreamReader(stream))
                                {
                                    try
                                    {
                                        return reader.ReadToEnd();
                                    }
                                    catch (Exception e)
                                    {
                                        return e.Message;
                                    }
                                }
                            }
                        }
                    }
                }

            }

        }
        private static Rijndael GetRijndael(string key, string matriz)
        {
            var rijndeal = Rijndael.Create();
            rijndeal.Key = Encoding.ASCII.GetBytes(key);
            rijndeal.IV = Encoding.ASCII.GetBytes(matriz);

            return rijndeal;
        }
    }

}

