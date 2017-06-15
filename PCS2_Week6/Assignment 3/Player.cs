using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }
 
        BindingList<object> listOfOwnCards = new BindingList<object>();

        public void addToOwnCards (Card card)
        {
            listOfOwnCards.Add(card);
        }
    }
}
