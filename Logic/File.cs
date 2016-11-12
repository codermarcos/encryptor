using System;
using System.IO;
using System.Linq;

namespace Logic
{
    public class File : IDisposable
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Content { get; set; }

        public File(string path)
        {
            Path = path;
            Name = GetName();
        }

        private string GetName()
        {
            return Path.Substring(Path.LastIndexOf('\\') + 1, Path.Length - Path.LastIndexOf('\\') - 1);
        }

        public string Read()
        {
            using (var reader = new StreamReader(Path))
            {
                Content = reader.ReadToEnd();
                return Content;
            };
        }
        public void Save()
        {
            using (var writer = new StreamWriter(Path))
            {
                writer.Write(Content);
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
