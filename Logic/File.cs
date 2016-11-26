using System;
using System.IO;

namespace Logic
{
    public class File : IDisposable
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public string Password { get; set; }
        public string Extension { get; set; }

        public File(string path)
        {
            Path = path;
            Name = GetName();
            Extension = GetExtension();
        }

        private string GetName()
        {
            return Path.Substring(Path.LastIndexOf('\\') + 1, Path.Length - Path.LastIndexOf('\\') - 1);
        }
        private string GetExtension()
        {
            return Path.Substring(Path.LastIndexOf('.') + 1, Path.Length - Path.LastIndexOf('.') - 1);
        }

        public bool IsCrpFile()
        {
            return Extension == "crp";
        }

        public string Read()
        {
            using (var reader = new StreamReader(Path))
            {
                    return IsCrpFile() ? Output = reader.ReadToEnd() : Input = reader.ReadToEnd();
            };
        }

        public void Save()
        {
            using (var writer = new StreamWriter(Path))
            {
                writer.Write(IsCrpFile() ? Input : Output);
            };
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
