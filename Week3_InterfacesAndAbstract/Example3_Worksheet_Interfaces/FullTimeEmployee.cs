using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstract.Example3_Worksheet_Interfaces
{
    public class FullTimeEmployee: IEmployee
    {
        public string Name { get; set; }
        public decimal MonthlySalary { get; set; }
        public int YearsOfService { get; set; }

        public decimal CalculateBonus()
        {
            if (YearsOfService < 5)
                return (0.05M) * (CalculateSalary() * 12);
            else if (YearsOfService >= 5 && YearsOfService <= 10)
                return (0.1M) * (CalculateSalary() * 12);
            else return (0.15M) * (CalculateSalary() * 12);
        }

        public decimal CalculateSalary()
        {
            return MonthlySalary;
        }
    }
}
