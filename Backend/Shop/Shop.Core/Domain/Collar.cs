using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class Collar : TapeBase
    {
        public double NeckCircuit { get; protected set; }
        public bool PetIdRing { get; protected set; }
        public string ClaspType { get; protected set; }
        public Collar(string color, double width, string type, string comments, double price,
            string fixturesColor, double neckCircuit, string claspType, bool petIdRing)
            : base(color,width,type,comments,price,fixturesColor)
        {
            NeckCircuit = neckCircuit;
            PetIdRing = petIdRing;
            ClaspType = claspType;
        }
    }
}
