using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Deck
    {
        List<Card> CardDeck = new List<Card>();

        public void CreateDeck()
        {
            int myEnumMemberCount = Enum.GetValues(typeof(Card.CardSuits)).Length;

            for (int i = 0; i < myEnumMemberCount; i++)
            {
                foreach (Enum e in Enum.GetValues(typeof(Card.CardTypes)))
                {
                    Card card = new Card(((Card.CardSuits)i).ToString(), e.ToString());
                    CardDeck.Add(card);
                }
            }
        }
    }
}
