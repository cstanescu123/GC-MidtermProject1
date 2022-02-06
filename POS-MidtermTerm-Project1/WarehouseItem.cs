using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    public class WarehouseItem : Product
    {
        int productID;
        string name;
        string description;
        string category;
        double price;
        char productChar;

        public static WarehouseItem FromCsv(string csvLine)
        {
            string[] lines = csvLine.Split(',');
            WarehouseItem item = new WarehouseItem();
            item.productID = int.Parse(lines[0]);
            item.name = lines[1];
            item.description = lines[2];
            item.category = lines[3];
            item.price = int.Parse(lines[4]);
            item.productChar = char.Parse(lines[5]);

            return item;
        }

        public static List<Product> ToInventory(WarehouseItem inventory)
        {
            foreach (WarehouseItem item in List<Product>)
            {
                Product product = new Product();
                product.productID = item.productID;
                product.name = item.name;
                product.description = item.description;
                product.category = item.category;
                product.price = item.price;
                product.productChar = item.productChar;
                return product;

            }

            return List<Product>; 
                      
        }
    }
}
