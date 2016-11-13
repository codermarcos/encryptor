using System;
using System.Linq;
using System.Numerics;

namespace Logic
{
    public class Functions
    {
        public static byte[] HexToBytes(string text)
        {
            var bytes = text.Length / 2;
            var retorno = new byte[bytes];
            for (var i = 0; i < bytes; i++)
            {
                retorno[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
            }
            return retorno;
        }

        public static string BytesToHex(byte[] bytes)
        {
            return string.Concat(Array.ConvertAll(bytes, b => b.ToString("X2")));
        }

        public static string StringToHex(string text)
        {
            return text.Aggregate(string.Empty, (current, c) => current + ((int) c).ToString("X"));
        }

        public static string StringToBin(string text)
        {
            return text.Aggregate(string.Empty, (current, c) => current + Convert.ToString((int)c, 2));
        }
    }
}
