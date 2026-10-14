using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_InheritanceAndPolymorphism.Example2
{
    public class SavingsBankAccount: BankAccount
    {

        public double InterestRate { get; set; }

        public double Withdraw(double amount)
        {
            if(Balance-amount >= 0 )
            {
                Balance = Balance - amount;
            }
            return Balance;
        }
    }
}
