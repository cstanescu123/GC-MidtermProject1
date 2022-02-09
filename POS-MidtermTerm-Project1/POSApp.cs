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
                List<CartItem> cart = new List<CartItem>();
                string userName = Menu.Welcome("Hello! Welcome the greatest cafe ever!", "Please tell me your name: ");
                Menu.ShowMenu("Here is our amazing list of items!");
                List<Product> product = new List<Product>();
                Warehouse.getInventory();

                string message = "";
                Console.WriteLine("Please select your item by entering 2 digits. So for item 1, you would input 01.");
                foreach (product product in product)
                {

                }
                Menu.SelectItemsForCart(product, message);
                //Verify cart is correct
                Console.ReadLine(); //to creat a break
                Calc calc = new Calc(4.99, 2);
                Calculator.CalculateReceipt(calc.GetSubTotal()); //this is to show subtotal per item or for the whole cart?
                                      
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
               // Menu.ShowCartItems(); //this will ouput the final receipt once payment has occured

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
