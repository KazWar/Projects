using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class StoplightsControl : UserControl
    {
        public TrafficLight TrafficLight;

        Timer timer = new Timer();
        public static int activeLight = 0;

        public StoplightsControl()
        {
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            activeLight++;
            if (activeLight == 3)
            {
                activeLight = 0;
            }

            pbTrafficLights.Refresh();
        }

        private void btnSmaller_Click(object sender, EventArgs e)
        {
            if (TrafficLight != null)
            {
                TrafficLight.Size -= 10;
                pbTrafficLights.Refresh();
            }
        }

        private void btnBigger_Click(object sender, EventArgs e)
        {
            if (TrafficLight != null)
            {
                TrafficLight.Size += 10;
                pbTrafficLights.Refresh();
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
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

        public void SetTitle(string text)
        {
            lblName.Text = text;
        }

        private void pbTrafficLights_Paint(object sender, PaintEventArgs e)
        {
            if (TrafficLight != null)
            {
                TrafficLight.Draw(e.Graphics);
            }
        }
    }
}
