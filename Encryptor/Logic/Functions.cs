using System;
using System.Linq;
using System.Text;

namespace Logic
{
    public class Functions
    {
        private static readonly char[] Alfabeto = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
        
        public static string HexToString(string text)
        {
            var bytes = text.Length / 2;
            var retorno = new byte[bytes];
            for (var i = 0; i < bytes; i++)
            {
                retorno[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
            }
            return Encoding.ASCII.GetString(retorno);
        }

        public static string StringToHex(string text)
        {
            return text.Aggregate(string.Empty, (current, c) => current + ((int) c).ToString("X"));
        }

        public static string LettersToAlphabetPosition(string letters)
        {
            return letters.Aggregate(string.Empty, (current, c) => current + (char.IsLetter(c) ? Alfabeto.ToList().IndexOf(char.Parse(c.ToString().ToUpper())) : c).ToString());
        }
    }
}
