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
            
            //subtotal = item[i] * price * qty in cart
            //foreach loop base on CartIem class/method within class
            foreach (var cartItem in CartMethod)
            {
                //takes price that is associate with item[i], then multiply by qty in cart
                subTotal = subTotal + subTotal;
            }

            return subTotal;
        }

        public void CalculateReceipt(double subTotal)
        {           
            double salesTax = 0.06; 
            double grandTotal = subTotal + (subTotal * salesTax);
            

            //itemized list portion of receipt
            foreach (var cartItem in CartMethod)
            {
                Console.WriteLine(item);
            }
            
            //financials of receipt            
            Console.WriteLine(subTotal);
            Console.WriteLine(salesTax);
            Console.WriteLine(grandTotal);
        }
    }
}
