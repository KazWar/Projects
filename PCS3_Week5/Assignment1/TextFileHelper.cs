using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class TextFileHelper
    {
        public void SaveToFile_Paranoid(string fileName, List<string> lines, bool allowAppend = true)
        {
          
            FileStream stream = null;
            try
            {
                stream = new FileStream(fileName, allowAppend ? FileMode.OpenOrCreate : FileMode.Create, FileAccess.Write);
                var writer = new StreamWriter(stream);
                stream.Seek(0, SeekOrigin.End);
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
            }
            finally
            {
                if (stream != null)
                {
                    try
                    {
                        stream.Flush();
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
            }
        }

        public void SaveToFile(string fileName, List<string> lines, bool allowAppend = true)
        {
            using (var stream = new FileStream(
                fileName, 
                allowAppend ? FileMode.OpenOrCreate : FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream)) {
                    stream.Seek(0, SeekOrigin.End);
                    foreach (var line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
        }
    }


        public List<string> LoadFromFile(string fileName)
        {
            var lines = new List<string>();
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        lines.Add(line);
                    }
                }
            }
            return lines;
        }
    }
}
