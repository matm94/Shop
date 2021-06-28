using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class ReversibleLeash : TapeBase
    {
        public bool StandardCirclePosition { get; protected set; }
        public double CirclePositionLength { get; protected set; }

        public ReversibleLeash(string color, double width, string type, string comments, 
            double lenght, double price, string fixturesColor, bool standardCirclePosition, double circlePositionLength) 
            : base(color,width,type,comments,lenght,price,fixturesColor)
        {
            StandardCirclePosition = standardCirclePosition;
            CirclePositionLength = circlePositionLength;
        }
    }
}
