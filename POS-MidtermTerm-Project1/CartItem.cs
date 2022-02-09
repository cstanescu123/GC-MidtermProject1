using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    public class CartItem
    {
        public double Quantity { get; set; }
        public Product Product { get; set; }
        public string ProductName { get; set; }
    }
}
