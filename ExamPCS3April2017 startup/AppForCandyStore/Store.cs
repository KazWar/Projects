using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForCandyStore
{
    class Store
    {
        private string name; //the name of this shop
        private List<Candy> soldCandy; //a list holding the sold candy

        public string Name { get { return this.name; } }

        public Store(string name)
        {
            this.name = name;
            this.soldCandy = new List<Candy>();
        }

        public void AddCandy(Candy c)
        {
            this.soldCandy.Add(c);
        }

        /// <summary>
        /// returns a list of all sold mixed candy
        /// </summary>
        /// <returns></returns>
        public List<Candy> GetAllSoldCandy()
        {
            return this.soldCandy;
        }

        public List<Candy> GetSoldMixedCandy()
        {
            var listOfMixedCandy = new List<Candy>();

            foreach (MixedCandy MC in soldCandy)
            {
                listOfMixedCandy.Add(MC);
            }

            return listOfMixedCandy;
        }

        /// <summary>
        /// returns an array with 3 numbers
        /// the first number is the total weight of lollipops of all sold mixed candy,
        /// the second number is the total weight of chewing gums of all sold mixed candy,
        /// the third number is the total weight of gummy drops of all sold mixed candy,
        /// </summary>
        /// <returns></returns>
        public int[] GetWeightsMixedCandy()
        {
            /* 
             From list of MixedCandy, select each object (Each has 3 props: weightLollipops, weightChewingGums, weightGummyDrops)
             and count the total sum of each property in all objects.
             Then put the results in an array and return it to the user.
             */

            var list = GetSoldMixedCandy();

            int[] ArrayOfWeights = {(list.Cast<MixedCandy>().Sum(x => x.weightLollipops)),
                (list.Cast<MixedCandy>().Sum(x => x.weightChewingGums)),
                (list.Cast<MixedCandy>().Sum(x => x.weightGummyDrops))};
            //int[] Array = { 0, 0, 0 };

            //Array[0] += list.Cast<MixedCandy>().Sum(x => x.weightChewingGums);

            return ArrayOfWeights;
        }

    }
}
