using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstract.Example2
{
    public class OrderItem
    {
        public string Item { get; set; }
        public double Price { get; set; }
    }
    public interface IPayment
    {
        string Recipient { get; set; }
        double Amount { get; set; }
        string Currency { get; set; }
        string Sender { get; set; }
        
        double TaxRate { get; set; }

        double CalculateTax();
        double CalculateTotal();
        string IssueTaxInvoice(List<OrderItem> items);
    }
}
