using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class CurrencyForm : Form
    {
        List<Currency> listOfCurrencies = new List<Currency>();
        public CurrencyForm()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var infoForm = new InfoForm();
            infoForm.Show();
            //   string pictureLocation = 
            pictureBox1.Image = Image.FromFile("../../images/Yen_sign.png");
        }

        private void btnConvertTo_Click(object sender, EventArgs e)
        {
            tbValue1.Text = (CurrencyConverter.ConvertFrom(Convert.ToDecimal(tbValue2.Text), nmudExchangeValue.Value)).ToString();
        }

        private void btnConvertFrom_Click(object sender, EventArgs e)
        {
            tbValue2.Text = (CurrencyConverter.ConvertTo(Convert.ToDecimal(tbValue1.Text), nmudExchangeValue.Value)).ToString();
        }
    }
}
