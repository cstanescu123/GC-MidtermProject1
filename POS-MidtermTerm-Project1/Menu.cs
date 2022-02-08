using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    public class Menu
    {
        public static string Welcome(string message, string otherMessage)
        {
            Console.WriteLine(message);
            Console.Write(otherMessage);
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}!");
            return userName;
        }

        public static List<Product> SelectItems(string message, string otherMessage)
        {
            Console.WriteLine(message);
            Console.WriteLine("");
            List<Product> inventory = Warehouse.getInventory();
            foreach (var product in inventory)
            {
                Console.WriteLine($"[{product.ProductID}] {product.Name} {product.Description} {product.Category} {product.Price}");
            }
            Console.WriteLine("");
            Console.WriteLine(otherMessage);

            return inventory;
        }
        public static string AskForPayment(string howToPay)
        {
            string userPaymentMethod;
                Console.WriteLine($"{howToPay} Cash, Check, or Credit Card?");
                userPaymentMethod = Console.ReadLine().Trim().ToLower();
                if (userPaymentMethod != "cash" && userPaymentMethod != "check" && userPaymentMethod != "credit card")
                {   
                    return "";
                }
                else
                {
                    return userPaymentMethod;
                }
        }
        public static List<Product> ShowCartItems()
        {
            List<Product> inventory = Warehouse.getInventory();
            foreach (var product in inventory)
            {
                Console.WriteLine(product);
            }
            return inventory;
        }
        //    List<string> products = new List<string>();

        //    while (!streamReader.EndOfStream)
        //    {
        //        products.Add(streamReader.ReadLine());

        //        foreach (string product in products)
        //        {

        //            Console.WriteLine(product);
        //        }
    }
}
