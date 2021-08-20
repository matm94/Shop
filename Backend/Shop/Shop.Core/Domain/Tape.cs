using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class Tape
    {
        public double ChestCircuit { get;  set; }
        public double ChestShoulderDistanceUp { get;  set; }
        public double ChestShoulderDistanceDown { get;  set; }
        public double CirclePositionLength { get;  set; }
        public string ClaspType { get;  set; }
        public string Color { get;  set; }
        public string Comments { get;  set; }
        public string FixturesColor { get;  set; }
        public bool Handle { get;  set; }
        public Guid Id { get;  set; }
        public double Lenght { get;  set; }
        public double NeckCircuit { get;  set; }
        public bool PetIdRing { get;  set; }
        public double Price { get;  set; }
        public bool SemiRing { get;  set; }
        public double ShoulderCircuit { get;  set; }
        public bool StandardCirclePosition { get;  set; }
        public string Type { get;  set; }
        public double Width { get;  set; }

        public Guid ProductId{ get; set; }
        public Product Product { get; set; }

    }
}
