using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class Suspenders : TapeBase
    {
        public double ShoulderCircuit { get; protected set; }
        public double ChestCircuit { get; protected set; }
        public double ChestShoulderDistanceUp { get; protected set; }
        public double ChestShoulderDistanceDown { get; protected set; }
        public string ClaspType { get; protected set; }
        public bool SemiRing { get; protected set; }
        public bool PetIdRing { get; protected set; }

        public Suspenders(string Color, double Width,string Type, string comments,
            double price, string fixturesColor, double shoulderCircuit, double chestCircuit, double chestShoulderDistanceUp,
            double chestShoulderDistanceDown, string claspType)
            : base(Color,Width,Type,comments,price,fixturesColor)
        {
            ShoulderCircuit = shoulderCircuit;
            ChestCircuit = chestCircuit;
            ChestShoulderDistanceUp = chestShoulderDistanceUp;
            ChestShoulderDistanceDown = chestShoulderDistanceDown;
            ClaspType = claspType;
        }

    }
}
