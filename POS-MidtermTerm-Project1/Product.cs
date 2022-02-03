using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    public class Product
    {
        public string name { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public double price { get; set; }

        internal Product(string productName, string prodcutDescription, 
                         string productCategory, double productPrice)
        {
            name = productName;
            category = productCategory;
            description = prodcutDescription;
            price = productPrice;
        }
    }    
}
