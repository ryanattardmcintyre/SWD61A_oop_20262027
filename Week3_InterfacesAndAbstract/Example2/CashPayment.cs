using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstract.Example2
{
    public class CashPayment : IPayment, IDiscount
    {
        public string Recipient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Currency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Sender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double TaxRate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double DiscountRate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double CalculateDiscount()
        {

            if (DiscountRate >= 1)
            {
                //18
                return ((DiscountRate / 100) * Amount);
            }
            else if (DiscountRate > 0)
            {
                return DiscountRate * Amount;
            }
            else
            {
                throw new Exception("Invalid discount rate");
            }
        }

        public double CalculateTax()
        {

            if (TaxRate >= 1)
            {
                //18
                return ((TaxRate / 100) * (Amount-CalculateDiscount()));
            }
            else if (TaxRate > 0)
            {
                return TaxRate * (Amount - CalculateDiscount());
            }
            else
            {
                throw new Exception("Invalid tax rate");
            }
        }

        public double CalculateTotal()
        {
            double subtotal = Amount - CalculateDiscount();
            double total = subtotal + CalculateTax();
            return total;
        }

        public string IssueTaxInvoice(List<OrderItem> items)
        {
            string output = "Invoice for ABC Ltd\n";
            foreach (var item in items)
            {
                output += $"{item.Item} \t {Currency}{item.Price}\n";
            }
            output += "---------------------------\n";
            output += $"Discount: {CalculateDiscount()}\n";
            output += $"Tax: {CalculateTax()}\n";
            output += $"Total: {CalculateTotal()}\n";

            return output;
        }
    }
}
