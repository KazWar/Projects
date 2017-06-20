using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Deck
    {
        public List<Card> CardDeck = new List<Card>();

        public Deck()
        {
            CreateDeck();
        }

        public void CreateDeck()
        {
            int myEnumMemberCount = Enum.GetValues(typeof(Card.CardSuits)).Length;

            for (int i = 0; i < myEnumMemberCount; i++)
            {
                foreach (Enum e in Enum.GetValues(typeof(Card.CardTypes)))
                {
                    Card card = new Card(((Card.CardSuits)i).ToString(), e.ToString(),(Card.CardSuits)i);
                    CardDeck.Add(card);
                }
            }
        }

        public void CardToString()
        {
            string.Format("{0} of {1}", CardType, CardSuite);
        }
    }
}
