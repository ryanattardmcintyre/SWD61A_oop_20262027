using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstract.Example2
{
    public class CardPayment : IPayment
    {
        public string Recipient { get; set; }
        public double Amount { get; set;}

        private string currency;
        public string Currency { //property accessing the field: currency
            get { 
                return currency.ToUpper(); //EUR, USD, GBP, ...
            }
            set { currency = value; } 
        }
        public string Sender { get; set; }
        public double TaxRate { get; set; }

        /// <summary>
        /// Method calculates tax of the amount specified in the currency stored
        /// </summary>
        /// <param name="taxRate">taxRate should be in decimal form</param>
        /// <returns></returns>
        public double CalculateTax()
        {

            //amount = 100Eur
            //tax = 18
            //output = Eur18

            if(TaxRate >=1)
            {
                //18
                return ((TaxRate / 100) * Amount);
            }
            else if(TaxRate > 0)
            {
                return TaxRate * Amount;
            }
            else
            {
                throw new Exception("Invalid tax rate");
            }
        }

        public double CalculateTotal()
        { 
            return CalculateTax() + Amount;
        }

        public string IssueTaxInvoice(List<OrderItem> items)
        {
            string output = "Invoice for ABC Ltd\n";
            foreach(var item in items)
            {
                output += $"{item.Item} \t {Currency}{item.Price}\n";
            }
            output += "---------------------------\n";
            output += $"Tax: {CalculateTax()}\n";
            output += $"Total: {CalculateTotal()}\n";

            return output;
        }

         
    }
}
