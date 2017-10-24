using Assignment1.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        BindingList<string> listOfCalculations = new BindingList<string>();
        MathOperations MO;

        string tempString;
        public Form1()
        {
            InitializeComponent();
            lbCalculations.DataSource = null;
            lbCalculations.DataSource = listOfCalculations;
        }

        public void addToList(string toBeAddedString)
        {
            listOfCalculations.Add(toBeAddedString);
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            MO = new MathOperations();
            var V = new InputValidator();
            try
            {
                var arg1 = V.ValidateNumber(tbNumber1.Text);
                var arg2 = V.ValidateNumber(tbNumber2.Text);

                tempString = string.Format("{0} {1} {2} = {3}", arg1 ,((Button)sender).Text,arg2 , MO.SelectArithmaticMethod(Convert.ToInt32(((Button)sender).Tag), Convert.ToInt32(arg1), Convert.ToInt32(arg2)));

                addToList(tempString);

                tempString = null;

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                }
            }
            catch (InvalidInputException ex)
            {
                addToList(String.Format("Invalid input: {0}", ex.Input));
            }
            catch (MissingInputException)
            {
                addToList("Missing input, please enter numeric values");
            }
            catch (Exception ex)
            {
                addToList(String.Format("Oops, something went wrong: {0}", ex.Message));
            }
        }
    }
}
