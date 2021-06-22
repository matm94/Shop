using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class Collar : TapeBase
    {
        public double NeckCircuit { get; set; }
        public bool PetIdRing { get; set; }
        public string ClaspType { get; set; }
        public Collar(string color, double width, string type, string comments, double price,
            string fixturesColor, double neckCircuit, string claspType)
            : base(color,width,type,comments,price,fixturesColor)
        {
            NeckCircuit = neckCircuit;
            PetIdRing = true;
            ClaspType = claspType;
        }
    }
}
