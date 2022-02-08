using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    public class CartAction : CartItem
    {
        public static string ShowCartItems(List<CartItem> userSelection)
        {
            string result = string.Empty;
            var cart = new List<CartItem>();
            foreach (var cartItem in userSelection)
            {
               result = $"{cartItem.Product.Name} ${cartItem.Product.Price} {cartItem.Quantity}\n"; //add cart qty
            }
            return result;
        }


    }
}
