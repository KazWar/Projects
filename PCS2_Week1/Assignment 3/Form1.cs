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
        ToolTip tt = new ToolTip();
        public Form1()
        {
            InitializeComponent();
        }

        private void tbA_MouseHover(object sender, EventArgs e)
        {
            tt.Show("Please enter a whole number", tbA, 0, 20, 1000);
        }

        private void tbB_MouseHover(object sender, EventArgs e)
        {
            tt.Show("A whole number, not 0", tbB, 0, 20, 1000);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            tbIntDiv.Text = (Convert.ToInt32(tbA.Text) / Convert.ToInt32(tbB.Text)).ToString();
            tbRemainder.Text = (Convert.ToInt32(tbA.Text) % Convert.ToInt32(tbB.Text)).ToString();
        }
    }
}
