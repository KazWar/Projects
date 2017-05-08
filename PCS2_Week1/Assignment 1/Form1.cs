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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           var result = Add(Convert.ToInt32(tbInput1.Text), Convert.ToInt32(tbInput2.Text));
           tbResult.Text = result.ToString();

        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            tbResult.Text = (Substract(Convert.ToInt32(tbInput1), Convert.ToInt32(tbInput2))).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            tbResult.Text = (Divide(Convert.ToInt32(tbInput1), Convert.ToInt32(tbInput2))).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            tbResult.Text = (Multiply(Convert.ToInt32(tbInput1), Convert.ToInt32(tbInput2))).ToString();
        }

        static int Substract(int value1, int value2)
        {
            int result = value1 - value2;
            return result;
        }
        static int Add(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
        }
        static int Multiply(int value1, int value2)
        {
            int result = value1 * value2;
            return result;
        }
        static int Divide(int value1, int value2)
        {
            int result = value1 / value2;
            return result;
        }
    }
}
