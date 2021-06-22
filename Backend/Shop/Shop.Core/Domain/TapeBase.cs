using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public abstract class TapeBase
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public double Width { get; set; }
        public string Type { get; set; }
        public string Comments { get; set; }
        public double Lenght { get; set; }
        public double Price { get; set; }
        public string FixturesColor { get; set; }
        public bool Handle { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        /// <summary>
        /// Constructor for Reverisible and Normal Leash
        /// </summary>
        /// <param name="color"></param>
        /// <param name="width"></param>
        /// <param name="type"></param>
        /// <param name="comments"></param>
        /// <param name="length"></param>
        /// <param name="price"></param>
        /// <param name="fixturesColor"></param>
        public TapeBase(string color, double width, string type, string comments, double length,
            double price, string fixturesColor)
        {
            Color = color;
            Width = width;
            Type = type;
            Comments = comments;
            Price = price;
            Lenght = length;
            FixturesColor = fixturesColor;
        }

        /// <summary>
        /// Constructor for TrainingLeash
        /// </summary>
        /// <param name="color"></param>
        /// <param name="comments"></param>
        /// <param name="length"></param>
        /// <param name="price"></param>
        /// <param name="handle"></param>
        public TapeBase(string color, string comments, double length,
             double price, bool handle)
        {
            Color = color;
            Comments = comments;
            Price = price;
            Lenght = length;
            Handle = handle;
        }

        /// <summary>
        /// Constructor for Collar and Suspenders
        /// </summary>
        /// <param name="color"></param>
        /// <param name="width"></param>
        /// <param name="type"></param>
        /// <param name="comments"></param>
        /// <param name="price"></param>
        /// <param name="fixturesColor"></param>
        public TapeBase(string color, double width, string type, string comments,
            double price, string fixturesColor)
        {
            Color = color;
            Width = width;
            Type = type;
            Comments = comments;
            Price = price;
            FixturesColor = fixturesColor;
        }

    }
}
