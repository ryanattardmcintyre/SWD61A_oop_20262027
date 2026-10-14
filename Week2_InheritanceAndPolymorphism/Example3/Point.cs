using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_InheritanceAndPolymorphism.Example3
{

    /* Create a class called Point
     * - public properties: x, y
     * - protected properties: colour ConsoleColor
     * - methods: Draw(): string => "This is a point at (x,y)" [Change the colour of the text]
     * 
     * Create another class called Circle: Point
     * - public properties: x, y, radius
     * - protected properties: colour
     * - methods Draw(): string => "This is a circle at (x,y) with radius: r"
     * - methods FindArea() : double 
     * - methods FindPerimeter() : double
     * 
     * Create another class called Sphere
     * - public properties: x, y, z, radius
     * - protected properties: colour
     * - methods Draw(): string => "This is a sphere at (x,y,z) with radius: r"
     * - methods FindArea() : double //Find surface area
     * - methods FindPerimeter() : double
     * 
     * Create another class called Cylinder
     * - public properties: x, y, z, height, radius
     * - protected properties: colour
     * - methods Draw(): string => "This is a cylinder at (x,y,z) with radius: r & height : h"
     * - methods FindArea() : double 
     * - methods FindPerimeter() : double
     */


    public class Point
    {
        protected ConsoleColor Colour { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public virtual string Draw()
        {
            Console.ForegroundColor = Colour;
            return $"This is a Point at ({X},{Y})";
        }

    }
}
