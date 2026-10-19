using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_InheritanceAndPolymorphism.Example3
{
    public class Cylinder: Sphere
    {
        public Cylinder (int x, int y, int z, double radius,  double height, ConsoleColor color)
            : base(x, y, z, radius, color)
        {
            Height = height;
        }

        public double Height { get; set; }

        public override string Draw()
        {
            Console.ForegroundColor = Colour;
            return base.Draw();
        }
        public override double FindArea()
        {
            return base.FindArea();
        }

        public override double FindPerimeter()
        {
            return base.FindPerimeter();
        }

        public override double FindVolume()
        {
            return base.FindVolume();
        }
    }
}
