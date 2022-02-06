using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    public class Warehouse
    {
        public class WarehouseItem : Product
        {
            public static List<Product> getInventory()
            {
                string dbpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filepath = dbpath + @"\Products.txt";

                List<Product> products = File.ReadAllLines(filepath)
                                             .Skip(1)
                                             .Select(p => WarehouseItem.FromCsv(p))
                                             .ToList();
                return products;
            }
            static WarehouseItem FromCsv(string products)
            {
                string[] lines = products.Split(',');
                WarehouseItem item = new WarehouseItem();
                item.productID = int.Parse(lines[0]);
                item.name = lines[1];
                item.description = lines[2];
                item.category = lines[3];
                item.price = int.Parse(lines[4]);
                item.productChar = char.Parse(lines[5]);
                
                return item;
                
            }


        }
    }
}
