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
            var products = File.ReadAllLines(filepath);

            return products.Select(x => parseFile(x))
                           .ToList();                           
        }
        private static Product parseFile(string input)
        {
            var i = input.Trim().Split(',');
            return new Product { ProductID = int.Parse(i[0]), Name = (i[1]).Trim(), Description = (i[2]).Trim(), Category = (i[3]).Trim(), Price = double.Parse(i[4]) };
        }


    }
}
