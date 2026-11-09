using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClasses
{
    public class Fish: Item
    {
        public double Weight { get; set; }
        public override double CalculateBill()
        {
            return Price * Weight * 1.18;
        }
    }
}
