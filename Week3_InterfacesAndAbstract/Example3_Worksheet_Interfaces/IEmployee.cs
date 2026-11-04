using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstract.Example3_Worksheet_Interfaces
{
    public interface IEmployee: ISalary, IBonus
    {
        string Name { get; set; }
    }
}
