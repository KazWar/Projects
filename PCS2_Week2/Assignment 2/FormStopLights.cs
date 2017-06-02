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
            new TrafficLight(){ Name = "LEFT", Size = 25 },
            new TrafficLight(){ Name = "CENTER", Size = 50 },
            new TrafficLight(){ Name = "RIGHT", Size = 75 }
        };
        List<Panel> listOfPanels = new List<Panel>();

        public FormStopLights()
        {
            InitializeComponent();
            addPanel();
        }
        public void addPanel()
        {
           
        }

        private void PbTrafficLights_Paint(object sender, PaintEventArgs e)
        {
            listOfTrafficLights.ElementAt(0).Draw(e.Graphics);
        }

        public void addPanels()
        {
            foreach (var item in listOfTrafficLights)
            {
                Panel TrafficlightPanel = new Panel();
                TrafficlightPanel.BackColor = Color.Black;
                TrafficlightPanel.Location = new Point(10, 10);
                TrafficlightPanel.Size = new Size(90, 90);

                listOfPanels.Add(TrafficlightPanel);
            }
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
