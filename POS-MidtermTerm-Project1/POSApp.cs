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
            bool anotherOrder = true;
            while (anotherOrder)
            {            
                string userName = Menu.Welcome("Hello! Welcome the greatest cafe ever!", "Please tell me your name: ");
                //Menu.SelectItems("Here is our amazing list of items!", "What would you like to order?");
                
                //Display items in cart
                //Verify cart is correct
                //Show price (subtotal, tax, grand total)
                        
                string paymentType = Menu.AskForPayment("How would you like to pay for your awesome items?");
                if (paymentType == "cash")
                {                
                    double cashOwed = CashRegister.GetPaidInCash(25.55);                                
                    if (cashOwed != 0) Console.WriteLine($"Here is your change {cashOwed - 0}.");
                }
                else if (paymentType == "check")
                {
                    CashRegister.GetPaidByCheck(25.66);
                }
                else
                {
                    CashRegister.GetPaidWithCreditCard(25.66);
                }            
                var cartItems = new List<string>();
                Menu.ShowReceipt(cartItems);
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
