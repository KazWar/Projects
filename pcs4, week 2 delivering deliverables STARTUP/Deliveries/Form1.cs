using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveries
{
    public partial class Form1 : Form
    {

        string dataFilePersonsLocation = @"C:\Users\kazik\OneDrive\Documenten\Visual Studio 2015\Projects\pcs4, week 2 delivering deliverables STARTUP\Deliveries\data\persons.txt";
        string dataFileDeliverablesLocation = @"C:\Users\kazik\OneDrive\Documenten\Visual Studio 2015\Projects\pcs4, week 2 delivering deliverables STARTUP\Deliveries\data\deliverables.txt";
        TransportCompany TC;

        public Form1()
        {
            InitializeComponent();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            TC = new TransportCompany();

            try
            {
                TC.LoadPersonsFromFile(dataFilePersonsLocation);
                TC.LoadDeliverablesFromFile(dataFileDeliverablesLocation);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

            listBox1. = TC.Deliverables;
        }

        private void btSortByWeight_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.DataSource = TC.SortByWeight();
        }

        private void btSortByName_Click(object sender, EventArgs e)
        {

        }

        private void btSortById_Click(object sender, EventArgs e)
        {

        }

        private void btSortByAddress_Click(object sender, EventArgs e)
        {

        }

        private void btSortForPostman_Click(object sender, EventArgs e)
        {

        }
    }
}
