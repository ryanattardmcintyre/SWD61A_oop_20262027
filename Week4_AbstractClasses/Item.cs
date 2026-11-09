using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClasses
{

    //1. An abstract class allows the developer to implement
    //and declare methods side-by-side
    //2. An abstract class is a hybrid between an interface and a class
    //3. An abstract class acts like an interface because
         //a) it allows you to leave methods without an implementation
         //b) it cannot be instantiated (cannot create an object)
         //c) it has to be implemented eventually to be used as an object

    //4. An abstract class acts like an ordinary class because
         //a) you have to override the abstract methods
         //b) you can inherit up to 1 abstract class

    public abstract class Item
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name} /t Eur {Price}");
            Console.WriteLine($"{Description}");
        }
        public abstract double CalculateBill();
    }
}
