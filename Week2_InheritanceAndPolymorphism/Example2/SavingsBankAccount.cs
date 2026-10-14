using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_InheritanceAndPolymorphism.Example2
{
    public class SavingsBankAccount: BankAccount
    {
        public SavingsBankAccount()
        {
            InterestRate = 0.0025;
        }
        public double InterestRate { get; set; }

        //dynamic polymorphism (part 1):
        //is when you need to change the implementation of a method
        // in eventual inherited classes
        public virtual double Withdraw(double amount)
        {
            if(Balance-amount >= 0 )
            {
                Balance = Balance - amount;
            }
            return Balance;
        }
    }
}
