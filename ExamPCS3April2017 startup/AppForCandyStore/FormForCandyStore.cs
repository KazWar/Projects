using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForCandyStore
{
    public partial class FormForCandyStore : Form
    {
        private Store myStore;
        private string[] namesPackedCandy; //the names of the packed candy
        private double[] pricesPackedCandy;//the corresponding prices of the packed candy
        private List<int> listOfWeights;
        private double pricePerKilogramMixedCandy;

        public FormForCandyStore()
        {
            InitializeComponent();
            this.myStore = new Store("Kazik's candy store");
            this.Text = this.myStore.Name;
            this.addSomeData();

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(tbNameSalesperson.Text)))
            {
                var salesPerson = tbNameSalesperson.Text;
                var chosenOption = panelRadioButtons.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();

                switch (chosenOption)
                {
                    case "PackedCandy":
                        if (!(string.IsNullOrWhiteSpace(tbNumberOfBags.Text)) && lbPackedCandy.SelectedIndex != -1)
                        {
                            var NoOfBags = Convert.ToInt32(tbNumberOfBags.Text);
                            var SelectedItem = lbPackedCandy.SelectedIndex;

                            try
                            {
                                myStore.AddCandy(new PackedCandy(salesPerson,
                                namesPackedCandy[SelectedItem].ToString(),
                                pricesPackedCandy[SelectedItem],
                                NoOfBags));

                                MessageBox.Show(string.Format($"Sold {NoOfBags} bag(s) of {namesPackedCandy[SelectedItem].ToString()} for {pricesPackedCandy[(SelectedItem)]}"));
                            }
                            catch (Exception E)
                            {
                                MessageBox.Show(E.Message);
                            }

                        } else
                        {
                            MessageBox.Show("Please select an item from the list and/or write a purchase amount.");
                        }
                        break;

                    case "MixedCandy":
                        foreach (TextBox control in gbMixedCandy.Controls)
                        {
                            if (!((string.IsNullOrWhiteSpace(control.Text)) && Convert.ToInt32(control.Text) > 0))
                            {
                                try
                                {
                                    listOfWeights.Add(Convert.ToInt32(control));
                                }
                                catch (Exception E)
                                {
                                    MessageBox.Show(E.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please provide a mixed candy amount higher or equal than 1 gram.");
                            }
                        }

                        try
                        {
                            myStore.AddCandy(new MixedCandy(salesPerson,
                                pricePerKilogramMixedCandy,
                                listOfWeights[0],
                                listOfWeights[1],
                                listOfWeights[2]
                                ));

                            MessageBox.Show(string.Format($"Sold {listOfWeights[0]} grams of lollipops, {listOfWeights[1]} grams of chewing Gum, {listOfWeights[2]} grams of gummy drops, for a total of {listOfWeights.Sum()} grams of mixed candy."));
                        }
                        catch (Exception E)
                        {
                            MessageBox.Show(E.Message);
                        }
                        break;

                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please fill in the sales person name.");
                tbNameSalesperson.Focus();
            }

        }

        private void btnShowAllSoldCandy_Click(object sender, EventArgs e)
        {
            if (!(myStore.GetAllSoldCandy().Count() < 1))
            {
                var soldCandy = myStore.GetAllSoldCandy();
                foreach (var item in soldCandy)
                {
                    lbOverview.Items.Add(item.GetInfo());
                }
            }
            else
            {
                lbOverview.Items.Clear();
                lbOverview.Items.Add("No candy has been sold!");
            }
        }

        private void btnShowSoldMixedCandy_Click(object sender, EventArgs e)
        {
            if (!(myStore.GetSoldMixedCandy().Count() < 1))
            {
                var soldMixedCandy = myStore.GetSoldMixedCandy();
                foreach (var item in soldMixedCandy)
                {
                    lbOverview.Items.Add(item.GetInfo());
                }
            }
            else
            {
                lbOverview.Items.Clear();
                lbOverview.Items.Add("No mixed candy has been sold!");
            }
        }

        private void btnShowWeightsMixedCandy_Click(object sender, EventArgs e)
        {
            var array = myStore.GetWeightsMixedCandy();

            try
            {
                this.lbOverview.Items.Add(string.Format($"{array[0]} grams of lollipops, {array[1]} grams of chewing gums, {array[2]} grams of gummy drops have been sold."));
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btnSaveInformationToFile_Click(object sender, EventArgs e)
        {
            //todo, assignment 3

        }

        //the methods below are already implemented
        private void addSomeData()
        {
            this.namesPackedCandy = new String[] { "Twix", "M&M", "Gummy bears", "Soft jelly beans", "Chocolate bars" };
            this.pricesPackedCandy = new double[] { 2.95, 1.90, 4.00, 3.50, 3.00 };
            this.showNamesAndPricesOfPackedCandy();

            this.pricePerKilogramMixedCandy = 12.00;
            this.gbMixedCandy.Text = "mixed candy, price per kilogram is " + this.pricePerKilogramMixedCandy.ToString("F2");

        }
        private void showNamesAndPricesOfPackedCandy()
        {
            this.lbPackedCandy.Items.Clear();
            String holder;
            for (int i = 0; i < this.namesPackedCandy.Length; i++)
            {
                holder = this.namesPackedCandy[i] + "- " + this.pricesPackedCandy[i].ToString("F2");
                this.lbPackedCandy.Items.Add(holder);
            }
        }
        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            if (this.rbPackedCandy.Checked)
            { //change the price of the selected packed candy
                int index = this.lbPackedCandy.SelectedIndex;
                this.pricesPackedCandy[index] = Convert.ToDouble(tbPrice.Text);
                this.showNamesAndPricesOfPackedCandy();
            }
            else
            {//change the price for the mixed candy
                this.pricePerKilogramMixedCandy = Convert.ToDouble(tbPrice.Text);
                this.gbMixedCandy.Text = "mixed candy, price per kilogram is " + this.pricePerKilogramMixedCandy.ToString("F2");
            }
        }
    }
}
