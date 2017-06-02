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
    public partial class FormStopLights : Form
    {
        // Initiliaze list of traffic lights
        List<TrafficLight> listOfTrafficLights = new List<TrafficLight>
        {
            new TrafficLight("LEFT",25),
            new TrafficLight("CENTER",50),
            new TrafficLight("RIGHT",75)
        };

        public FormStopLights()
        {
            InitializeComponent();
        }

        private void FormStopLights_Load(object sender, EventArgs e)
        {
            int totalWidth = 0;
            foreach (var trafficLight in listOfTrafficLights)
            { 
                var stoplights = new StoplightsControl();
                stoplights.SetTitle(String.Format("{0}", trafficLight.Name));
                stoplights.Left = totalWidth;
                stoplights.TrafficLight = trafficLight;
                this.Controls.Add(stoplights);
                totalWidth = totalWidth + stoplights.Width;
            }
            this.ClientSize = new Size(totalWidth, this.ClientSize.Height);
        }
    }
}
