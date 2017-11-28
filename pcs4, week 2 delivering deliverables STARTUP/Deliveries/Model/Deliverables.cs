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
            Sort();
            return this;
        }
    }
}
