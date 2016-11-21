using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Logic.Criptographys
{
    public class Mikcipher
    {
        private string Content { get; set; }

        public Mikcipher(string text)
        {
            Content = text;
        }

        public string Encript(string publicKey)
        {
            var cKey = Encoding.ASCII.GetString(Functions.HexToBytes(publicKey));

            var divisor = cKey.IndexOf('|');
            var pkey = int.Parse(cKey.Substring(0, divisor));
            var key = int.Parse(cKey.Substring(divisor+1, cKey.Length - divisor - 1 ));
            var input = Encoding.ASCII.GetBytes(Content);

            return input.Aggregate(string.Empty, (current, c) => current + ((Convert.ToInt16(c)*pkey/key) + " "));
        }


        public string Decript(string privatekey)
        {
            var key = GetKey(privatekey);

            var input = Content.Split(' ');

            var retorno = new byte[input.Length];

            for (var i = 0; i < input.Length; i++)
            {
                var result = string.IsNullOrEmpty(input[i]) ? Convert.ToByte(0) : Convert.ToByte(Convert.ToInt16(input[i])/key);
                retorno[i] = result;
            }
            return Encoding.ASCII.GetString(retorno);
        }

        public string GetPublickey(string publicKey, string privateKey)
        {
            var keyP = GetKey(publicKey);
            var keyR = GetKey(privateKey);
            return Functions.StringToHex((keyP * keyR) + "|" + keyP);
        }

        private int GetKey(string key)
        {
            var retorno = string.Empty;
            var contador = string.Empty;
            var entrada = Functions.LettersToAlphabetPosition(Functions.StringToHex(key));

            foreach (var c in entrada)
            {
                contador += c;

                if (contador.Length != 2) continue;
                retorno += Convert.ToInt16(contador[0]) - Convert.ToInt16(contador[1]);
                contador = string.Empty;                
            }

            contador = retorno.Replace("-", string.Empty);

            retorno = contador.Aggregate("0", (current, c) => (Convert.ToInt16(current) + Convert.ToInt16(c.ToString())).ToString());

            return Convert.ToInt16(retorno);
        }
    }
}
