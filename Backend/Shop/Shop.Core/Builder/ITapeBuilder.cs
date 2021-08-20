using Shop.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Builder
{
    public interface ITapeBuilder
    {
        public Tape Build();
        public TapeBuilder SetChestCircuit(double chestCircuit);
        public TapeBuilder SetChestShoulderDistanceUp(double chestShoulderDistanceUp);
        public TapeBuilder SetChestShoulderDistanceDown(double chestShoulderDistanceDown);
        public TapeBuilder SetCirclePositionLength(double circlePositionLength);
        public TapeBuilder SetClaspType(string claspType);
        public TapeBuilder SetColor(string color);
        public TapeBuilder SetComments(string comments);
        public TapeBuilder SetFixturesColor(string fixturesColor);
        public TapeBuilder SetHandle(bool handle);
        public TapeBuilder SetId(Guid id);
        public TapeBuilder SetLenght(double lenght);
        public TapeBuilder SetNeckCircuit(double neckCircuit);
        public TapeBuilder SetPetIdRing(bool petIdRing);
        public TapeBuilder SetPrice(double price);
        public TapeBuilder SetSemiRing(bool semiRing);
        public TapeBuilder SetShoulderCircuit(double shoulderCircuit);
        public TapeBuilder SetStandardCirclePosition(bool standardCirclePosition);
        public TapeBuilder SetType(string type);
        public TapeBuilder SetWidth(double width);


    }
}
