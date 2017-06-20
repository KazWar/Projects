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
    public partial class CardGameForm : Form
    {
        private Players Players;
        public CardGameForm()
        {
            InitializeComponent();
            FormClosing += CardGameForm_FormClosing;
        }
        

        public CardGameForm(Players players) : this()
        {
            this.Players = players;
        }


        private void CardGameForm_Activated(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            this.Width = Players.Count * 185;
            foreach (Player player in Players)
            {
                PlayerControl PlayerControl = new PlayerControl(player, deck);
                panelPlayers.Controls.Add(PlayerControl);
            }
        }


        private void CardGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
