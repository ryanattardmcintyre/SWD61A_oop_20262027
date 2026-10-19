using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_InheritanceAndPolymorphism.Example3
{
    public class Sphere: Circle
    {
        public Sphere(int x, int y, int z, double radius, ConsoleColor color) : base(x, y, radius, color)
        {
            Z = z;
        }

        public int Z { get; set; }

        public override string Draw()
        {
            Console.ForegroundColor = Colour;
            return $"This is a Sphere at ({X}, {Y}, {Z}) with radius {Radius}";
        }

        public override double FindArea()
        {
            return 4 * Math.PI * Radius * Radius;
        }

        public virtual double FindVolume()
        {
            return (4 / 3) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
