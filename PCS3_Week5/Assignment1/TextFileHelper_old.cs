using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public class TextFileHelper_old
    {
        private string FileName { get; set; }
        private FileStream fs = null;
        private StreamWriter sw = null;
        private StreamReader sr = null;
        
        public TextFileHelper_old(string fileName = null)
        {
            this.FileName = fileName;

            try
            {
                fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

            sw = new StreamWriter(fs);
            sr = new StreamReader(fs);
        }

        public void SaveToFile(List<string> lines)
        {
            sw.Write("test");
            if (lines.Count() != 0)
            {
                try
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    sw.Close();
                }
            }

            MessageBox.Show(string.Format($"{lines.Count()} lines of text were saved!"));
        }

        //public List<string> LoadFromFile()
        //{

        //    try
        //    {
        //        while (!sr.EndOfStream)
        //        {

        //        }
        //        sr.Read();
        //       return sr.Read()
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        sr.Close();
        //    }
        //}
    }
}
