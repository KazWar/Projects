using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class PlayerControl : UserControl
    {
        Random random = new Random();
        public Player Player { get; private set; }
        public Deck Deck { get; private set; }

        private PlayerControl()
        {
            InitializeComponent();
        }


        public PlayerControl(Player player, Deck deck) : this()
        {
            Player = player;
            Deck = deck;
            labelPlayerName.Text = Player.Name;
            labelPlayerPoints.Text = player.Points.ToString();

            listBoxPlayerCards.DataSource = null;
            listBoxPlayerCards.DataSource = deck.CardDeck;
            
        }


        private void buttonDrawCard_Click(object sender, EventArgs e)
        {
            Player.addToOwnCards(Deck.CardDeck.ElementAt(random.Next(0, 20)));
        }


        private void buttonSelectCard_Click(object sender, EventArgs e)
        {

        }

        private void buttonRdyUp_Click(object sender, EventArgs e)
        {

        }
    }
}
