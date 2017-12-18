using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deliveries.Model;

namespace Deliveries
{
    public partial class formDeliveryManager : Form
    {

        string dataFilePersonsLocation = @"..\..\Data\persons.txt";
        string dataFileDeliverablesLocation = @"..\..\Data\deliverables.txt";
        TransportCompany TC;

        public formDeliveryManager()
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

            SortBy(DeliverableSortOrder.Id);
        }

        /// <summary>
        /// Remembers the last used sort order,
        /// so that we can re-sort by the same field, when direction checkbox is clicked
        /// </summary>
        private DeliverableSortOrder CurrentOrder = DeliverableSortOrder.Id;

        /// <summary>
        /// Sorts the collection of deliverables and re-populates the list
        /// </summary>
        /// <param name="order">Sort order</param>
        private void SortBy(DeliverableSortOrder order)
        {
            if (TC != null && TC.Deliverables != null)
            {
                var direction = checkboxSortDescending.Checked ? SortDirection.Descending : SortDirection.Ascending;
                listBox1.DataSource = null;
                listBox1.Items.Clear();
                listBox1.DataSource = TC.Deliverables.SortBy(order, direction);
                listBox1.DisplayMember = "DisplayText";
                CurrentOrder = order;
            }
        }

        private void btSortByWeight_Click(object sender, EventArgs e)
        {
            SortBy(DeliverableSortOrder.Weight);
        }

        private void btSortByName_Click(object sender, EventArgs e)
        {
            SortBy(DeliverableSortOrder.BuyerName);
        }

        private void btSortById_Click(object sender, EventArgs e)
        {
            SortBy(DeliverableSortOrder.Id);
        }

        private void btSortByAddress_Click(object sender, EventArgs e)
        {
            SortBy(DeliverableSortOrder.BuyerAddress);
        }

        private void checkboxSortDescending_CheckedChanged(object sender, EventArgs e)
        {
            SortBy(CurrentOrder);
        }
    }
}
