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
        Timer timer = new Timer();
        Random random = new Random();
        public Form1()
        {
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            timer.Interval += 10;
        }

        private void ButtonChangeColor_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            {
                timer.Stop();
            }
            else if (timer.Enabled == false)
            {
                timer.Start();
            }
        }
    }
}
