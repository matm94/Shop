using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Models
{
    public class CollarDTO
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public double Width { get; set; }
        public string Type { get; set; }
        public string Comments { get; set; }
        public double Price { get; set; }
        public string FixturesColor { get; set; }
        public double NeckCircuit { get; set; }
        public bool PetIdRing { get; set; }
        public string ClaspType { get; set; }
    }
}
