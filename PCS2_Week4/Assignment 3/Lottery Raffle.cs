using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        Lottery lottery;
        int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateLottery_Click(object sender, EventArgs e)
        {
            if (counter == 0 )
            {
                if (string.IsNullOrWhiteSpace(textBoxMaxValue.Text) == true && string.IsNullOrWhiteSpace(textBoxNumbersOfWantedNrs.Text) == true)
                {
                    MessageBox.Show("Please enter one or more values for in the empty textboxes.");
                    textBoxMaxValue.Focus();
                }
                else
                {
                    lottery = new Lottery(Convert.ToInt32(textBoxMaxValue.Text), Convert.ToInt32(textBoxNumbersOfWantedNrs.Text));
                    if (lottery != null)
                    {
                        buttonDrawNextNumber.Enabled = true;
                        buttonDrawAllNumbers.Enabled = true;
                        textBoxMaxValue.ReadOnly = true;
                        textBoxNumbersOfWantedNrs.ReadOnly = true;
                    }

                    counter++;
                }

            }
            else
            {
                DialogResult newObjectWarning = MessageBox.Show("Do you want to create a new lottery?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (newObjectWarning == DialogResult.Yes)
                {
                    ClearAllText(this);
                    textBoxMaxValue.ReadOnly = false;
                    textBoxNumbersOfWantedNrs.ReadOnly = false;
                    buttonDrawNextNumber.Enabled = false;
                    buttonDrawAllNumbers.Enabled = false;
                }

                counter--;
            }
        }
        public void ClearAllText(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void buttonDrawNextNumber_Click(object sender, EventArgs e)
        {
            if (lottery.listOfDrawnNumbers.Count() == lottery.NrOfWantedNumbers)
            {
                lottery.Draw1Number();
                RefreshListBox();
            }
        }

        private void RefreshListBox()
        {
            listBoxResults.DataSource = null;
            listBoxResults.DataSource = lottery.listOfDrawnNumbers;
        }
    }
}
