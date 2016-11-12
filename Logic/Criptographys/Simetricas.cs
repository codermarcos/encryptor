
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Logic.Criptographys
{
    public class Simetricas
    {
        public static string Rijndaels(string text, string key)
        {
            var bytesKey = Convert.FromBase64String(key);
            var bytesText = new UTF8Encoding().GetBytes(text);
            var bytesIv = new byte[] { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18, 0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };

            using (var rijndael = new RijndaelManaged { KeySize = 256 })
            {
                using (var memory = new MemoryStream())
                {
                    using (var encryptor = new CryptoStream(memory, rijndael.CreateEncryptor(bytesKey, bytesIv), CryptoStreamMode.Write))
                    {
                        encryptor.Write(bytesText, 0, bytesText.Length);
                        encryptor.FlushFinalBlock();
                        return Convert.ToBase64String(memory.ToArray());
                    }
                }
            }
        }
    }
}
