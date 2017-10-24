using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        List<ISomeone> myFamily = new List<ISomeone>()
        {
            new GrownUp("Elisa"),
            new GrownUp("Elbert"),
            new Dog(3),
            new Baby("Jake")
        };

        ISomeone FamilyInterface;

        public Form1()
        {
            InitializeComponent();
            RefreshListBox();
        }

        private void btnGoodMorning_Click(object sender, EventArgs e)
        {
            lbGoAway.Text = FamilyInterface.SayGoodMorning(Convert.ToInt32(nudWeekDays.Value));
        }

        private void btnGoodNight_Click(object sender, EventArgs e)
        {
            lbTrouble.Text = FamilyInterface.SayGoodNight(Convert.ToInt32(nudHours.Value));
        }

        private void RefreshListBox()
        {
            lbFamily.Items.Clear();

            foreach (ISomeone Person in myFamily)
            {
                lbFamily.Items.Add(Person.IntroduceYOurself());
            }
        }
    }
}
