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
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProductPrice { get; set; }
        public bool OrderStatus { get; set; }

        public Shipment Shipment { get; set; }

        public Order(string firstName, string lastName, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            TotalPrice(ProductPrice, Shipment.Price);
        }

        public decimal TotalPrice(decimal productPrice, decimal shipmentPrice)
        {
            return productPrice + shipmentPrice;
        }
    }
}
