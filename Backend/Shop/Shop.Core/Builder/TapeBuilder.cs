using Shop.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Builder
{
    public class TapeBuilder : ITapeBuilder
    {
        private Tape _tape = new Tape();

        public Tape Build()
        {
            return _tape;
        }

        public TapeBuilder SetChestCircuit(double chestCircuit)
        {
            _tape.ChestCircuit = chestCircuit;
            return this;
        }

        public TapeBuilder SetChestShoulderDistanceDown(double chestShoulderDistanceDown)
        {
            _tape.ChestShoulderDistanceDown = chestShoulderDistanceDown;
            return this;
        }

        public TapeBuilder SetChestShoulderDistanceUp(double chestShoulderDistanceUp)
        {
            _tape.ChestShoulderDistanceUp = chestShoulderDistanceUp;
            return this;
        }

        public TapeBuilder SetCirclePositionLength(double circlePositionLength)
        {
            _tape.CirclePositionLength = circlePositionLength;
            return this;
        }

        public TapeBuilder SetClaspType(string claspType)
        {
            _tape.ClaspType = claspType;
            return this;
        }

        public TapeBuilder SetColor(string color)
        {
            _tape.Color = color;
            return this;
        }

        public TapeBuilder SetComments(string comments)
        {
            _tape.Comments = comments;
            return this;
        }

        public TapeBuilder SetFixturesColor(string fixturesColor)
        {
            _tape.FixturesColor = fixturesColor;
            return this;
        }

        public TapeBuilder SetHandle(bool handle)
        {
            _tape.Handle = handle;
            return this;
        }

        public TapeBuilder SetId(Guid id)
        {
            _tape.Id = id;
            return this;
        }

        public TapeBuilder SetLenght(double lenght)
        {
            _tape.Lenght = lenght;
            return this;
        }

        public TapeBuilder SetNeckCircuit(double neckCircuit)
        {
            _tape.NeckCircuit = neckCircuit;
            return this;
        }

        public TapeBuilder SetPetIdRing(bool petIdRing)
        {
            _tape.PetIdRing = petIdRing;
            return this;
        }

        public TapeBuilder SetPrice(double price)
        {
            _tape.Price = price;
            return this;
        }

        public TapeBuilder SetSemiRing(bool semiRing)
        {
            _tape.SemiRing = semiRing;
            return this;
        }

        public TapeBuilder SetShoulderCircuit(double shoulderCircuit)
        {
            _tape.ShoulderCircuit = shoulderCircuit;
            return this;
        }

        public TapeBuilder SetStandardCirclePosition(bool standardCirclePosition)
        {
            _tape.StandardCirclePosition = standardCirclePosition;
            return this;
        }

        public TapeBuilder SetType(string type)
        {
            _tape.Type = type;
            return this;
        }

        public TapeBuilder SetWidth(double width)
        {
            _tape.Width = width;
            return this;
        }
    }
}
