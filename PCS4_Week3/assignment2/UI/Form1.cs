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
        public recursiveFunctionsForm()
        {
            InitializeComponent();
            lbMethods.DataSource = choices;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            switch (lbMethods.SelectedValue.ToString())
            {
                case "A":
                    tbResult.Text = calc.sumSquares(Convert.ToInt32(tbValueA.Text)).ToString();
                    break;
                case "B":
                    break;
                case "C":
                    break;
                case "D":
                    break;
                case "E":
                    break;
                case "F":
                    break;
                default:
                    break;
            }
        }
    }
}
