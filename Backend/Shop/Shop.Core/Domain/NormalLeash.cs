using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class NormalLeash : TapeBase
    {
        public NormalLeash(string color, double width, string type, string comments,
            double lenght, double price, string fixturesColor)
            : base(color, width, type, comments, lenght, price, fixturesColor)
        {

        }
    }
}
