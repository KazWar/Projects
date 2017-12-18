using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries.Model
{
    public class Deliverables: List<Deliverable>
    {
        public Deliverables SortBy(DeliverableSortOrder order, SortDirection direction = SortDirection.Ascending)
        {

            var comparer = new DeliverableComparer
            {
                Order = order,
                Direction = direction
            };
            Sort(comparer);
            return this;
        }
    }
    class DeliverableComparer : IComparer<Deliverable>
    {
        public DeliverableSortOrder Order;
        public SortDirection Direction;

        public int Compare(Deliverable x, Deliverable y)
        {
            int result = 0;
            switch (Order)
            {
                case DeliverableSortOrder.Id:
                    result = Comparer<int>.Default.Compare(x.ID, y.ID);
                    break;
                case DeliverableSortOrder.Weight:
                    result = Comparer<int>.Default.Compare(x.Weight, y.Weight);
                    break;
                case DeliverableSortOrder.BuyerName:
                    if (x.Buyer != null && y.Buyer != null)
                    {
                        result = String.Compare(x.Buyer.Name, y.Buyer.Name);
                    }
                    break;
                case DeliverableSortOrder.BuyerAddress:
                    if (x.Buyer != null && y.Buyer != null)
                    {
                        result = String.Compare(x.Buyer.Address, y.Buyer.Address);
                    }
                    break;
            }
            if (Direction == SortDirection.Descending)
            {
                result = -result;
            }
            return result;
        }
    }
}
