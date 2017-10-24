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

        public Form1()
        {
            InitializeComponent();
        }

        
        // File name, as entered in the input box
        private string FileName
        {
            get
            {
                var fileName = tbTextFileNameInput.Text;
                if (!String.IsNullOrWhiteSpace(fileName))
                {
                    // Add .txt extension, unless the user did it already
                    fileName = Path.ChangeExtension(fileName, ".txt");
                    tbTextFileNameInput.Text = fileName;
                }
                return fileName;
            }
            set { tbTextFileNameInput.Text = value; }
        }

        
        // Editor lines
        private List<string> Lines
        {
            get { return RtbInput.Lines.ToList(); }
            set { RtbInput.Lines = value.ToArray(); }
        }

        
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(FileName)))
            {
                var fileHelper = new TextFileHelper();
                fileHelper.SaveToFile(FileName, Lines);
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
                var fileHelper = new TextFileHelper();
                Lines = fileHelper.LoadFromFile(FileName);
            }
            else
            {
                MessageBox.Show("Please select a filename.");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Text files (*.txt) | *.txt"
            };
            openFileDialog.ShowDialog();
            FileName = openFileDialog.FileName;
        }
    }
}
