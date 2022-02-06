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



    }
}
