using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstract.Example3_Worksheet_Interfaces
{
    public class PartTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public decimal CalculateBonus()
        {
            if (HoursWorked > 80)
                return 0.05M * CalculateSalary();
            else return 0;
        }

        public decimal CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }
    }
}
