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

        public double GetSubTotal()
        {
            return Price * Quantity;
        }
        public double GetTax()
        {
            return GetSubTotal() * .06;
        }
        public double GetGrandTotal()
        {
            return GetSubTotal() + GetTax();
        }



    }
}
