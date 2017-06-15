using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Card
    {

        public Card(string cardSuite, string cardType)
        {
            CardSuite = cardSuite;
            CardType = cardType;
        }

        public string CardSuite { get; set; }

        public string CardType { get; set; }

        public enum CardSuits
        {
            Spades,
            Clubs,
            Diamonds,
            Hearts
        }

        public enum CardTypes
        {
            Ace,
            Jack,
            Queen,
            King,
            Ten
        }
    }
}
