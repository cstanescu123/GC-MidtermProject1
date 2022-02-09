using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    internal class Calc
    {
        //Subtotal = Price * Quantity
        //Tax = Subtotal * .06
        //GrandTotal = Subtotal + Tax

        public double Price { get; set; }
        public int Quantity { get; set; }

        public Calc(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public static double GetSubTotal(List<CartItem> cartItems)
        {
            double subtotal = 0;
            foreach (var item in cartItems)
            {
                subtotal = (item.Quantity) * (item.Product.Price) + subtotal;
            }
            return subtotal;
        }
        public static double GetTax(List<CartItem> cartItems)
        {
            return GetSubTotal(cartItems) * .06;
        }
        public static double GetGrandTotal(List<CartItem> cartItems)
        {        
            return  Math.Round((GetSubTotal(cartItems) + GetTax(cartItems)), 2);
        }
    }
}
