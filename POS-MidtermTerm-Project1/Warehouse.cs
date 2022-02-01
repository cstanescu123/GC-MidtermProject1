using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    internal class Warehouse
    {
        List<Product> Inventory;
        public static List<Product> getInventory()
        {
            string dbpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filepath = dbpath + @"\Products.txt";
            List<Product> products = new List<Product>();
            
            
            return products;

        }

        public static List<Product>
    }
}
