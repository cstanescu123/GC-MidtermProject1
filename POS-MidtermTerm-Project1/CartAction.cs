using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    public class CartAction
    {
        public void AddToCart(int id)
        {
            // Retrieve the product from the warehouse
            var cartItem = Warehouse.getInventory().SingleOrDefault(
                c => c.CartId == ShoppingCartId)
                && c.ProductID == id
        }
      
    }
}
