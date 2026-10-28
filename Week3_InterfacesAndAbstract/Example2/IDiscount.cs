using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstract.Example2
{
    public interface IDiscount
    {
        double DiscountRate { get; set; }
        double CalculateDiscount();
    }
}
