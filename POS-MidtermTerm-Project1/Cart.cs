using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    public class Cart
    {
        public List<CartItem> CartItem { get; set; }
        public double GrandTotal { get; set; }

        public Cart()
        {
            //products = new List<Products>
        }

    }
}
