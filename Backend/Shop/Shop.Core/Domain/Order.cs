using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class Order
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Phone(ErrorMessage ="Phone must contains 11 characters")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
        
        [Required]
        public double ProductPrice { get; set; }
        public string OrderStatus { get; set; }
        public double ShipmentPrice { get; set; }
        public string ShipmentStatus { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public Order(string firstName, string lastName, string phoneNumber, string email,
            string orderStatus, string shipmentStatus)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            OrderStatus = orderStatus;
            ShipmentStatus = shipmentStatus;
        }

        public string TotalPrice(double productPrice, double shipmentPrice)
        {
            var total = productPrice + shipmentPrice;
            return total.ToString();
        }
    }
}
