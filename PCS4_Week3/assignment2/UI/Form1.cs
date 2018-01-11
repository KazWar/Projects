using assignment2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class recursiveFunctionsForm : Form
    {
        calculations calc = new calculations();
        List<string> choices = new List<string>() { "A", "B", "C", "D", "E", "F" };
        int[] arrayOfInts = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public recursiveFunctionsForm()
        {
            InitializeComponent();
            lbMethods.DataSource = choices;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int ValueA = Convert.ToInt32(tbValueA.Text);
            //int ValueB = Convert.ToInt32(tbValueB.Text);
            string choice = lbMethods.SelectedValue.ToString();

            switch (choice)
            {
                case "A":
                    calc.sumSquares(ValueA);
                    break;
                case "B":
                    calc.sum(arrayOfInts, ValueA);
                    break;
                case "C":
                    break;
                case "D":
                    break;
                case "E":
                    break;
                case "F":
                    break;
            }

            tbResult.Text = calc.Result.ToString();
        }

        private void lbMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            calc.Result = 0;
        }
    }
}
