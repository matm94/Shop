using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class Shipment
    {
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
