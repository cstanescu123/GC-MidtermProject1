using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    internal class Calculator
    {
        public double CalculateSubTotal()
        {
            double subTotal = 0;  
            List<Product> cartMethod = new List<Product>();
            
            //subtotal = item[i] * price * qty in cart
            //foreach loop base on CartIem class/method within class
            foreach (var cartItem in cartMethod)
            {
                //takes price that is associate with item[i], then multiply by qty in cart
                subTotal = subTotal + subTotal;
            }
            return subTotal;
        }
        public static void CalculateReceipt(double subTotal)
        {           
            double salesTax = 0.06; 
            double grandTotal = subTotal + (subTotal * salesTax);
            List<Product> cartMethod = new List<Product>();

            //itemized list portion of receipt
            foreach (var cartItem in cartMethod)
            {
                Console.WriteLine(cartItem);
            }   
            //financials of receipt            
            Console.WriteLine(subTotal);
            Console.WriteLine(salesTax);
            Console.WriteLine(grandTotal);
        }
    }
}
