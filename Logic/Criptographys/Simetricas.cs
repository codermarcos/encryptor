
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Logic.Criptographys
{
    public class Simetricas
    {
        public static string Rijndaels(string text)
        {
            return "FALTA FAZER";
        }

        private static IEnumerable<byte> StringToBytes(string text, byte[] key, byte[] iv)
        {
            using (var rijndaels = Rijndael.Create())
            {
                var encryptor = rijndaels.CreateEncryptor(key, iv);
                using (var memory = new MemoryStream())
                {
                    using (var stream = new CryptoStream(memory, encryptor, CryptoStreamMode.Write))
                    {
                        using (var writer = new StreamWriter(stream))
                        {
                            writer.Write(text);
                        }
                        return memory.ToArray();
                    }
                }
            }
        }
    }
}
