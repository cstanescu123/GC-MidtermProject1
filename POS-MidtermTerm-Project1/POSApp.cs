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

            Console.SetWindowSize(82, 40);
            Console.Title = "THE BURGER HUT II - Point of Sale Application";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();

            string userName = Menu.Welcome("Hello! Welcome to the Burger Hut II: Where our Menu starts at 10!\n", "Please enter the name for your Order: ");
            bool anotherOrder = true;
            while (anotherOrder)
            {   
                List<CartItem> cart = new List<CartItem>();
                var userCart = Menu.SelectItemsForCart(Menu.ShowMenu("Here is our amazing list of delicious items!"), "Please enter the number corresponding to your food item!");
                Console.WriteLine($"   Subtotal: ${Calc.GetSubTotal(userCart)}");
                Console.WriteLine($"        Tax: ${Calc.GetTax(userCart)}");
                Console.WriteLine($"Grand Total: ${Calc.GetGrandTotal(userCart)}");                
                 
                string paymentType = Menu.AskForPayment("How would you like to pay for your awesome items?");
                if (paymentType == "cash")
                {                
                    double cashOwed = CashRegister.GetPaidInCash(Calc.GetGrandTotal(userCart));                                
                    if (cashOwed != 0) Console.WriteLine($"Change: ${cashOwed - 0}");
                }
                else if (paymentType == "check")
                {
                    CashRegister.GetPaidByCheck(Calc.GetGrandTotal(userCart));
                }
                else
                {
                    CashRegister.GetPaidWithCreditCard(Calc.GetGrandTotal(userCart));
                }

                Menu.ShowReceipt(userCart, paymentType);

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
