using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week2_InheritanceAndPolymorphism.Example3
{
    public class Circle: Point
    {
        public double Radius { get; set; }

        public override string Draw()
        {
            Console.ForegroundColor = Colour;
            return $"This is a circle at ({X}, {Y}) with radius {Radius}";
        }

        public virtual double FindArea()
        { return Math.PI * Math.Pow(Radius, 2);  }

        public virtual double FindPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
