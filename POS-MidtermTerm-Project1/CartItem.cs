using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    internal class CartItem : Warehouse
    {
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public double price { get; set; }
    }
}
