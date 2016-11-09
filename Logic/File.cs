using System;
using System.IO;
using System.Linq;

namespace Logic
{
    public class File : IDisposable
    {
        private readonly string _caminho;
        public File(string caminho)
        {
            _caminho = caminho;
        }

        public string Read()
        {
            using (var reader = new StreamReader(_caminho))
            {
                return reader.ReadToEnd();
            };
        }
        public void Write(string text)
        {
            using (var writer = new StreamWriter(_caminho))
            {
                writer.Write(text);
            };
        }

        public string ToBin()
        {
            return Read().Aggregate(string.Empty, (current, c) => current + Convert.ToString((int) c, 2));
        }
        public string ToHex()
        {
            return Read().Aggregate(string.Empty, (current, c) => current + ((int)c).ToString("X"));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
