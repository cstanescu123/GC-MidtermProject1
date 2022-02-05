using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    class Warehouse:Product
    {
        public static List<Product> getInventory()
        {
            string dbpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filepath = dbpath + @"\Products.txt";

            List<Product> products = File.ReadAllLines(filepath)
                                         .Skip(1)
                                         .Select(v => Product.FromCsv(v))
                                         .ToList();
            return products;

        }
        public class WarehouseItem
        {
            public int productID { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string category { get; set; }
            public double price { get; set; }
            public char productChar { get; set; }

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


        }

    }
}
