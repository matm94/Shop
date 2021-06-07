using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Models
{
    public class OrderDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal ProductPrice { get; set; }
        public bool OrderStatus { get; set; }
        public decimal ShipmentPrice { get; set; }
        public bool ShipmentStatus { get; set; }
    }
}
