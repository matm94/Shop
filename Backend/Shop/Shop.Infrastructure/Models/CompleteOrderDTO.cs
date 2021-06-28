using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Models
{
    public class CompleteOrderDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal ProductPrice { get; set; }
        public string OrderStatus { get; set; }
        public decimal ShipmentPrice { get; set; }
        public string ShipmentStatus { get; set; }
        public IEnumerable<CollarDTO> Collars { get; set; }
        public IEnumerable<NormalLeashDTO> NormalLeashes { get; set; }
        public IEnumerable<ReversibleLeashDTO> ReversibleLeashes { get; set; }
        public IEnumerable<SuspendersDTO> Suspenders { get; set; }
        public IEnumerable<TrainingLeashDTO> TrainingLeashes { get; set; }
    }
}
