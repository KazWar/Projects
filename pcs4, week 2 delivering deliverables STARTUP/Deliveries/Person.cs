using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliveries
{
    public class Person
    {
        private int id;
        private string name;
        private string street;
        private int housenumber;
        private string postalcode;
        private string city;

        public Person(int id, string name, string street, int housenumber, string postalcode, string city)
        {
            this.id = id;
            this.name = name;
            this.street = street;
            this.housenumber = housenumber;
            this.postalcode = postalcode;
            this.city = city;
        }

        public int ID { get { return this.id; } }
        public string Name { get { return this.name; } }
        public string Street { get { return this.street; } }
        public int Housenumber { get { return this.housenumber; } }
        public string Postalcode { get { return this.postalcode; } }
        public string City { get { return this.city; } }


        public override string ToString()
        {
            return this.name + " - " + this.street + "  " + this.housenumber + " - " + this.postalcode + "  " + this.city;
        }

    }
}
