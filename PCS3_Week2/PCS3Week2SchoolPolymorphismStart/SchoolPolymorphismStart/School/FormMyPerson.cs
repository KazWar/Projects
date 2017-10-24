using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class FormMyPerson : Form
    {
        public List<Person> Persons = new List<Person>();

        public FormMyPerson()
        {
            InitializeComponent();
            RefreshListBox();
        }

        //Where to place event handlers?
        private void lbPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPersons.SelectedItem != null)
            {
                labelMyPersonInfo.Text = Persons.ElementAt(lbPersons.SelectedIndex).InfoString();
            }
        }
                  

        private void buttonSchoolYearTeacher_Click(object sender, EventArgs e)
        {
            if (lbPersons.SelectedItem == null)
            {
                MessageBox.Show("Please select a teacher from the list.");
            }
            else
            {
                Persons.ElementAt(lbPersons.SelectedIndex).AnotherSchoolYear();
                LogPersonChange("year at Fontys");
            }
        }

        private void buttonBirthdayStudent_Click(object sender, EventArgs e)
        {
            Persons.ElementAtOrDefault(lbPersons.SelectedIndex).CelebrateBirthDay();
            LogPersonChange( "birthday");
        }
       

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = this.textBoxName.Text;
            int pcn = Convert.ToInt32(this.textBoxPCN.Text);
            int age = Convert.ToInt32(this.textBoxAge.Text);

            string checkedRadioBox = GBPersonTypes.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Tag.ToString();

            switch (checkedRadioBox)
            {
                case "person":
                    Persons.Add(new Person(name, pcn, age));
                    break;
                case "teacher":
                    decimal salary = Convert.ToDecimal(this.textBoxSalary.Text);
                    Persons.Add(new Teacher(name, pcn, age, salary));
                    break;
                case "student":
                    string country = this.textBoxCountry.Text;
                    Persons.Add(new Student(name, pcn, age, country));
                    break;
                default:
                    break;
            }
            LogPersonChange(string.Format($"CREATED {checkedRadioBox} :").ToUpper());

            RefreshListBox();
        }

        private void btnAddEC_Click(object sender, EventArgs e)
        {
            if (Persons.ElementAt(lbPersons.SelectedIndex) is Student)
            {
                ((Student)Persons.ElementAtOrDefault(lbPersons.SelectedIndex)).AddOneModuleEC();
                LogPersonChange("ADDED 3 EC's");
            }
            else
            {
                LogPersonChange("ERROR! PERSON IS NOT A STUDENT!");
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            if (Persons.ElementAt(lbPersons.SelectedIndex) is Teacher)
            {
                ((Teacher)Persons.ElementAtOrDefault(lbPersons.SelectedIndex)).MakePromotion();
                LogPersonChange("TEACHER PROMOTED!");
            }
            else
            {
                LogPersonChange("ERROR! PERSON IS NOT A TEACHER!");
            }
        }

        private void RefreshListBox()
        {
            lbPersons.Items.Clear();

            int i = 0;

            foreach (Person P in Persons)
            {
                lbPersons.Items.Add(Persons[i].Name);
                i++;
            }
        }

        private void LogPersonChange(string changeName)
        {
            var Selection = lbPersons.SelectedIndex;
            if (Selection < 0)
            {
                Selection = 0;
                this.richTextBoxActivityLogMyPerson.AppendText("\n*********************** " + changeName);
                this.richTextBoxActivityLogMyPerson.AppendText("\n" + Persons.ElementAtOrDefault(Selection).InfoString());
                this.labelMyPersonInfo.Text = Persons.ElementAtOrDefault(Selection).InfoString();
            }
            else
            {
                this.richTextBoxActivityLogMyPerson.AppendText("\n*********************** " + changeName);
                this.richTextBoxActivityLogMyPerson.AppendText("\n" + Persons.ElementAtOrDefault(lbPersons.SelectedIndex).InfoString());
                this.labelMyPersonInfo.Text = Persons.ElementAtOrDefault(lbPersons.SelectedIndex).InfoString();
            }
        }
    }
}
