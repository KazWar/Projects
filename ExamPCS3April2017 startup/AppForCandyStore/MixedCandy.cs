using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForCandyStore
{
    class MixedCandy : Candy
    {
        public double pricePerKilogram { get; set; }
        public int weightLollipops { get; set; }
        public int weightChewingGums { get; set; }
        public int weightGummyDrops { get; set; }

        public MixedCandy(string nameSalesperson, double pricePerKilogram, int weightLollipops, int weightChewingGums, int weightGummyDrops) : base(nameSalesperson)
        {
            this.pricePerKilogram = pricePerKilogram;
            this.weightLollipops = weightLollipops;
            this.weightChewingGums = weightChewingGums;
            this.weightGummyDrops = weightGummyDrops;
        }

        public override double GetPrice()
        {
            return ((GetTotalWeight() * pricePerKilogram) / 1000);
        }

        public override string GetInfo()
        {
            return base.GetInfo() + string.Format($", mixed candy with total weight {GetTotalWeight()}");
        }

        public int GetTotalWeight()
        {
            return weightChewingGums + weightGummyDrops + weightLollipops;
        }
    }
}
