using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Assignment_3
{
    public partial class FormMain : Form
    {
        BindingList<double> listOfGrades = new BindingList<double>();
        MethodController MC = new MethodController();
        public FormMain()
        {
            InitializeComponent();
            lbGrades.DataSource = null;
            lbGrades.DataSource = listOfGrades;
            foreach (Control c in tableLayoutPanel2.Controls)
            { 
                if (c is TextBox)
                {
                    c.Text = "0";
                }
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            MC.AddToList(tbAddToList.Text, listOfGrades);
            tbAddToList.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            MC.RemoveFromList(listOfGrades);
            MC.ClearAllText(this);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            tbSufficient.Text = listOfGrades.Where(i => i >= 5.5).Count().ToString();
            tbInsufficient.Text = listOfGrades.Where(i => i < 5.5).Count().ToString();
            tbTotal.Text = listOfGrades.Count().ToString();
            tbAverage.Text = listOfGrades.Average().ToString();

            if (Convert.ToDouble(tbInsufficient.Text) > (Convert.ToDouble(tbTotal.Text) * 0.5))
            {
                tbInsufficient.BackColor = Color.Red;
            }
        }
    }
}
