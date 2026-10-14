using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1_IntroductionToClasses;

namespace Week2_InheritanceAndPolymorphism.Example2
{
    public class BankAccount
    {
        public string Iban { get; set; }
        public double Balance { get; set; }
        public DateTime OpenedOn { get; set; }
        public bool Active { get; set; }
        public Person Owner { get; set; }

        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }

    }
}
