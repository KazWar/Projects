using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForCandyStore
{
    class PackedCandy : Candy
    {
        public int nrSold { get; set; }
        public double pricePerBag { get; set; }
        public string nameCandy { get; set; }

        public PackedCandy(string nameSalesperson, string nameCandy, double pricePerBag, int nrSold) : base(nameSalesperson)
        {
            this.nameCandy = nameCandy;
            this.pricePerBag = pricePerBag;
            this.nrSold = nrSold;
        }
        
        public override double GetPrice()
        {
            return nrSold * pricePerBag;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + string.Format($", sold {nrSold} of product {nameCandy}");
        }
    }
}
