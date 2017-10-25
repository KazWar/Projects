using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForCandyStore
{
    class TextFileHelper
    {
        public void SaveToFile(string fileName, List<string> lines, bool allowAppend = true)
        {
            using (var stream = new FileStream(
                fileName,
                allowAppend ? FileMode.OpenOrCreate : FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream))
                {
                    stream.Seek(0, SeekOrigin.End);
                    foreach (var line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
