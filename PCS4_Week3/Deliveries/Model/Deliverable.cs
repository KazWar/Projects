using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliveries.Model
{

    public class Deliverable
    { 

        public Deliverable(int id, int weight, Person buyer)
        {
            ID = id;
            Weight = weight;
            Buyer = buyer;
        }

        public int ID { get; private set; }
        public int Weight { get; private set; }
        public Person Buyer { get; private set; }


        public string DisplayText
        {
            get
            {
                if (Buyer == null)
                {
                    return string.Format($"Id:{ID}, weight:{Weight}, delivery address unknown");
                }
                else
                {
                    return string.Format($"Id:{ID}, weight:{Weight}, to be delivered at : {Buyer.DisplayText}");
                }

            }
        }
    }
}
