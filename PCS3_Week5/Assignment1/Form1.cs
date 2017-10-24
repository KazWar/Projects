using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        TextFileHelper TFH;
        string FileName = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(tbTextFileNameInput.Text)))
            {
                FileName = tbTextFileNameInput.Text + ".txt";
                TFH = new TextFileHelper();
                var rtbInput = RtbInput.Lines.ToList();
                TFH.SaveToFile(FileName, rtbInput);
            }
            else
            {
                MessageBox.Show("Please enter a filename or select one.");
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            if (FileName != null)
            {
                var TFH = new TextFileHelper();
                RtbInput.Text = TFH.LoadFromFile(FileName).ToString();
            }
            else
            {
                MessageBox.Show("Please select a filename.");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var OFD = new OpenFileDialog();
            OFD.Filter = "Text files (*.txt) | *.txt";

            OFD.ShowDialog();
            FileName = OFD.FileName;
            tbTextFileNameInput.Text = FileName;
        }
    }
}
