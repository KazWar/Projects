using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class GameStartForm : Form
    {
        
        public GameStartForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayerPanel.Controls.Clear();

            for (int i = 0; i <= comboBox1.SelectedIndex; i++)
            {
                addPlayerControl playerName = new addPlayerControl();
                PlayerPanel.Controls.Add(playerName);
            }
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            List<string> listOfInputs = new List<string>();

            foreach (Control control in PlayerPanel.Controls)
            {
                if (control is TextBox)
                {
                    listOfInputs.Add(control.Text);
                }
            }

            ValidateInput(listOfInputs);
        }

        private void ValidateInput(List<string> list)
        {
            List<string> listOfErrors = new List<string>();

            foreach (string input in list)
            {
                if (string.IsNullOrWhiteSpace(input) == true)
                {
                    listOfErrors.Add(input);
                }
            }

            if (listOfErrors != null)
            {
                MessageBox.Show("Please enter all the player's names");
            }
            else
            {
                this.Hide();
                CardGameForm GameForm = new CardGameForm();
                GameForm.Activate();
                GameForm.Show();
            }
        }
    }
}



//foreach (Control control in PlayerPanel.Controls)
//{
//    if (string.IsNullOrWhiteSpace(control.Text) == true)
//    {
//        MessageBox.Show("Please enter all the player's names");
//        break;
//    }
//    else
//    {
//        this.Hide();
//        CardGameForm GameForm = new CardGameForm();
//        GameForm.Activate();
//        GameForm.Show();
//        break;
//    }
//}