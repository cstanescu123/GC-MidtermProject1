using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    internal class POSApp
    {
        public static void Run()
        {


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();


            string userName = Menu.Welcome("Hello! Welcome the greatest cafe ever!", "Please tell me your name: ");
            bool anotherOrder = true;
            while (anotherOrder)
            {   
                List<CartItem> cart = new List<CartItem>();
                var userCart = Menu.SelectItemsForCart(Menu.ShowMenu("Here is our amazing list of items!"), "Please enter the 2 digit code for your order.");
                Console.WriteLine($"Your subtotal is ${Calc.GetSubTotal(userCart)}");
                Console.WriteLine($"Tax is ${Calc.GetTax(userCart)}");
                Console.WriteLine($"Your grandtotal is ${Calc.GetGrandTotal(userCart)}");                
                
                string paymentType = Menu.AskForPayment("How would you like to pay for your awesome items?");
                if (paymentType == "cash")
                {                
                    double cashOwed = CashRegister.GetPaidInCash(Calc.GetGrandTotal(userCart));                                
                    if (cashOwed != 0) Console.WriteLine($"Here is your change {cashOwed - 0}.");
                }
                else if (paymentType == "check")
                {
                    CashRegister.GetPaidByCheck(Calc.GetGrandTotal(userCart));
                }
                else
                {
                    CashRegister.GetPaidWithCreditCard(Calc.GetGrandTotal(userCart));
                }

                Menu.ShowReceipt(userCart);

                Console.WriteLine("Would you like to place another order?");
                string orderAgain = Console.ReadLine().Trim().ToLower();
                if (orderAgain == "yes")
                {
                    anotherOrder = true;
                }
                else
                {
                   anotherOrder = false;
                }
            }
            Console.WriteLine("Thank you for ordering with us, have a wonderful day!");
        }
    }
}
