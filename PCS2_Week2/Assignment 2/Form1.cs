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
        // Initiliaze list of traffic lights
        List<TrafficLight> listOfTrafficLights = new List<TrafficLight>
        {
            new TrafficLight(){ Name = "LEFT", Size = 25 },
            new TrafficLight(){ Name = "CENTER", Size = 50 },
            new TrafficLight(){ Name = "RIGHT", Size = 75 }
        };
        List<Panel> listOfPanels = new List<Panel>();

        public Form1()
        {
            InitializeComponent();
            addPanel();
        }
        public void addPanel()
        {
            listOfTrafficLights.ElementAt(1).

            foreach (TrafficLight Property in listOfTrafficLights)
            {
                lblName.Text = Property.Name;
                pbTrafficLights.Paint += PbTrafficLights_Paint;
            }
        }

        private void PbTrafficLights_Paint(object sender, PaintEventArgs e)
        {
            
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
    }
}
