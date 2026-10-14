using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_InheritanceAndPolymorphism.Example2
{
    public class LoanBankAccount: FixedTermBankAccount
    {
        public override double Withdraw(double amount)
        {
            if (DateTime.Now >= MaturityDate)
            {
                amount = Balance;
                Active = false;
                return 0;
            }
            //throw new Exception("You cannot withdraw money yet");
            return 0;
        }
    }
}
