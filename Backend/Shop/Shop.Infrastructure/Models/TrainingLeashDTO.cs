using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Models
{
    public class TrainingLeashDTO
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public string Comments { get; set; }
        public double Lenght { get; set; }
        public double Price { get; set; }
        public bool Handle { get; set; }
    }
}
