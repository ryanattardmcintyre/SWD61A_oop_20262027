using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_InheritanceAndPolymorphism.Example2
{
    public class FixedTermBankAccount: SavingsBankAccount
    {
        public DateTime MaturityDate { get; set; }

        public override double Withdraw(double amount)
        {
           if(DateTime.Now >= MaturityDate)
            {
                //base refers to the parent class
                return base.Withdraw(amount);
            }
            return 0;
        }
    }
}
