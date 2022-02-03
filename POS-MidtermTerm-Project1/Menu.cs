using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    public class Menu
    {
        public static void Welcome(string name)
        {
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}, to TEST Cafe");
        }

        public static void PresentMenu()
        {
            string dbpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filepath = dbpath + @"\Products.txt";
            using var fileStream = File.Open(filepath, FileMode.Open);
            using var streamReader = new StreamReader(fileStream);

            while (!streamReader.EndOfStream)
            {
                List<string> products = new List<string>();

                products.Add(streamReader.ReadLine());

                foreach (string product in products)
                {
                    Console.WriteLine(product);
                }

            }

        }

    }
}
