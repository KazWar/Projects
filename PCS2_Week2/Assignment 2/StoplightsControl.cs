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
        public StoplightsControl()
        {
            InitializeComponent();
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

        }

        public void SetTitle(string text)
        {
            lblName.Text = text;
        }


        public TrafficLight TrafficLight;


        private void pbTrafficLights_Paint(object sender, PaintEventArgs e)
        {
            if (TrafficLight != null)
            {
                TrafficLight.Draw(e.Graphics);
            }
        }
    }
}
