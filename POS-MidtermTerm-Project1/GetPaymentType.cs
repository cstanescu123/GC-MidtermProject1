using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    internal class GetPaymentType
    {
                
        
        public static void PaymentType(List<CartItem> userCart, string paymentStyle) 
        {
            if (paymentStyle == "cash")
                {                
                    double cashOwed = CashRegister.GetPaidInCash(Calc.GetGrandTotal(userCart));                                
                    if (cashOwed != 0) Console.WriteLine($"Change: ${cashOwed - 0}");
                }
                else if (paymentStyle == "check")
                {
                    CashRegister.GetPaidByCheck(Calc.GetGrandTotal(userCart));
                }
                else
                {
                    CashRegister.GetPaidWithCreditCard(Calc.GetGrandTotal(userCart));
                }
        }
    }
}
