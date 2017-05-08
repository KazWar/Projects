using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        bool isValidated = false;
        int result;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (isValidated == false)
            {
                btnCalculate.Enabled = false;
                MessageBox.Show("Not all values are valid.");
            } else
            {
                switch (tbOperand.Text)
                {
                    case "+":
                        result = Convert.ToInt32(tbValue1.Text) + Convert.ToInt32(tbValue2.Text);
                        break;
                    case "-":
                        result = Convert.ToInt32(tbValue1.Text) + Convert.ToInt32(tbValue2.Text);
                        break;
                    case "/":
                        result = Convert.ToInt32(tbValue1.Text) + Convert.ToInt32(tbValue2.Text);
                        break;
                    case "*":
                        result = Convert.ToInt32(tbValue1.Text) + Convert.ToInt32(tbValue2.Text);
                        break;
                    default:
                        MessageBox.Show("Please provide an valid operator which is - , + , * or /");
                        break;
                }

                lbResult.Text = result.ToString();
                ClearAllText(this);
            }
        }

        private void validateInput(object sender, EventArgs e)
        {
            TextBox tbText = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tbText.Text) == false)
            {
                if (Convert.ToInt32(tbText.Text) == 0)
                {
                    MessageBox.Show("Please enter a value that is not 0");
                } else
                {
                    isValidated = true;
                }
            }
        }

        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
    }
}
