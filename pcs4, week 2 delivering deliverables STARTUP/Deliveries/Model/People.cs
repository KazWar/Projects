using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries.Model
{
    public class People: List<Person>
    {
        public People SortBy(PersonSortOrder order, SortDirection direction = SortDirection.Ascending)
        {
            var comparer = new PersonComparer
            {
                Order = order,
                Direction = direction
            };
            Sort(comparer);
            return this;
        }

        class PersonComparer : IComparer<Person>
        {
            public PersonSortOrder Order;
            public SortDirection Direction;

            public int Compare(Person x, Person y)
            {
                int result = 0;
                switch (Order)
                {
                    case PersonSortOrder.Id:
                        result = Comparer<int>.Default.Compare(x.ID, y.ID);
                        break;
                    case PersonSortOrder.Name:
                        result = Comparer<string>.Default.Compare(x.Name, y.Name);
                        break;
                    case PersonSortOrder.City:
                        result = Comparer<string>.Default.Compare(x.City, y.City);
                        if (result == 0)
                            result = Comparer<string>.Default.Compare(x.Street, y.Street);
                        if (result == 0)
                            result = Comparer<int>.Default.Compare(x.Housenumber, y.Housenumber);
                        break;
                    case PersonSortOrder.Street:
                        result = Comparer<string>.Default.Compare(x.Street, y.Street);
                        if (result == 0)
                            result = Comparer<int>.Default.Compare(x.Housenumber, y.Housenumber);
                        break;
                    case PersonSortOrder.HouseNumber:
                        result = Comparer<int>.Default.Compare(x.Housenumber, y.Housenumber);
                        break;
                        // add other fields
                }
                if (Direction == SortDirection.Descending)
                {
                    result = -result;
                }
                return result;
            }
        }
    }
}
