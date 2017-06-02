using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._1
{
    public partial class InputForm : Form
    {
        ResultForm ResultForm = new ResultForm();
        public InputForm()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(InputForm_KeyPressEnter);
        }

        void InputForm_KeyPressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrWhiteSpace(textBoxInput.Text) == true)
                {
                    MessageBox.Show("Please enter a value into the box.");
                    textBoxInput.Focus();
                }
                else if (Convert.ToInt32(textBoxInput.Text) == 0)
                {
                    this.Hide();
                    ResultForm.Activate();
                    ResultForm.refresh();
                    ResultForm.Show();
                }
                else
                {
                    ResultForm.addToListOfResults(Convert.ToInt32(textBoxInput.Text));
                    textBoxInput.Clear();
                }
            }
        }

        private void ButtonEnterInput_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxInput.Text) == true)
            {
                MessageBox.Show("Please enter a value into the box.");
                textBoxInput.Focus();
            } else
            {
                ResultForm.addToListOfResults(Convert.ToInt32(textBoxInput.Text));
                textBoxInput.Clear();
            }
        }
    }
}
