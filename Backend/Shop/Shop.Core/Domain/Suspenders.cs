using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class Suspenders : TapeBase
    {
        public double ShoulderCircuit { get; set; }
        public double ChestCircuit { get; set; }
        public double ChestShoulderDistanceUp { get; set; }
        public double ChestShoulderDistanceDown { get; set; }
        public string ClaspType { get; set; }
        public bool SemiRing { get; set; }
        public bool PetIdRing { get; set; }

        public Suspenders(string tapeColor, double tapeWidth,string tapeType, string comments,
            double price, double shoulderCircuit, double chestCircuit, double chestShoulderDistanceUp, 
            double chestShoulderDistanceDown, string claspType, string fixturesColor) 
            : base(tapeColor,tapeWidth,tapeType,comments,price,fixturesColor)
        {
            ShoulderCircuit = shoulderCircuit;
            ChestCircuit = chestCircuit;
            ChestShoulderDistanceUp = chestShoulderDistanceUp;
            ChestShoulderDistanceDown = chestShoulderDistanceDown;
            ClaspType = claspType;
        }
    }
}
