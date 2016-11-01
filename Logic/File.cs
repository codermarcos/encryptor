using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class File
    {
        private string ReadHex(string file)
        {
            using (var reader = new BinaryReader(new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.None)))
            {
                reader.BaseStream.Position = 0x0;
                var bytes = reader.ReadBytes(0x10); 
                return BitConverter.ToString(bytes);
            };
        }
        public static string Read(string caminho, string file)
        {
            using (var reader = new StreamReader(caminho))
            {
                return reader.ReadToEnd();
            };
        }
        public static void Write(string file)
        {
            using (var writer = new StreamWriter(file))
            {
                writer.Write(file);
            };
        }
    }
}
