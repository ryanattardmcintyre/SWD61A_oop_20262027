using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClasses
{
    public class Beverage : Item
    {
        public override double CalculateBill()
        {
            return Price * 1.18;
        }
    }
}
