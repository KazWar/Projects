using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliveries.Model
{
    public class Person
    {

        public Person(int id, string name, string street, int housenumber, string postalcode, string city)
        {
            ID = id;
            Name = name;
            Street = street;
            Housenumber = housenumber;
            PostalCode = postalcode;
            City = city;
        }
        
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Street { get; private set; }
        public int Housenumber { get; private set; }
        public string PostalCode { get; private set; }
        public string City { get; private set; }

        public string Address
        {
            get
            {
                var address = new List<string>()
                {
                    City,
                    Street,
                    Housenumber.ToString(),
                    PostalCode
                };
                return String.Join(" ", address.Where(a => !String.IsNullOrWhiteSpace(a)));
            }
        }


        public string DisplayText
        {
            get
            {
                return String.Format("{0} - {1} - {2} - {3} {4}", Name, Street, Housenumber, PostalCode, City);
            }
        }

    }
}
