using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        int[] array = new int[20];
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 20; i++)
            {
                int number = random.Next(0, 999);
                array[i] = number;
            }

            lbNumbers.DataSource = array;
            textBoxAverage.Text = array.Average().ToString();
            textBoxHighest.Text = array.Max().ToString();
            textBoxLowest.Text = array.Min().ToString();
            textBoxTotal.Text = array.Sum().ToString();
            textBoxOdd.Text = array.Where(c => c % 2 == 0).Count().ToString();

        }
    }
}
