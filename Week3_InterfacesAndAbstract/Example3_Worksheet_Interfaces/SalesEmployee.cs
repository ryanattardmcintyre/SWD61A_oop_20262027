using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstract.Example3_Worksheet_Interfaces
{
    public class SalesEmployee : IEmployee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal MonthlySales { get;set; }
        public decimal CalculateBonus()
        {
            if (MonthlySales > 20000)
                return 0.05M * MonthlySales;
            else return 0;
        }

        public decimal CalculateSalary()
        {
            return BaseSalary + (0.03M * MonthlySales);
        }
    }
}
