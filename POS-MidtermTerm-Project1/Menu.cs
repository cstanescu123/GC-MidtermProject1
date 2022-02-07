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
            string userName = Console.ReadLine(); //Do we want to test for null?
            Console.WriteLine($"Welcome {userName}!");
            return userName;
        }

        public static List<Product> SelectItems(string message, string otherMessage)
        {
            Console.WriteLine(message);
            List<Product> userOrder = Warehouse.getInventory();
            Console.WriteLine(otherMessage);
            //should we call the cart item function here?
            return userOrder;
        }
        public static string AskForPayment(string howToPay)
        {
            //  bool paymentStyle = true;
            string userPaymentMethod;
            // while (paymentStyle)
            {
                Console.WriteLine($"{howToPay} Cash, Check, or Credit Card?");
                userPaymentMethod = Console.ReadLine().Trim().ToLower();
                if (userPaymentMethod != "cash" && userPaymentMethod != "check" && userPaymentMethod != "credit card")
                {
                    //       paymentStyle = true;
                    return "";
                }
                //   paymentStyle = false;
                return userPaymentMethod;
            }
        }
        public static void ShowReceipt(List<string> cartItems)
        {
            foreach (var item in cartItems)
            {
                Console.WriteLine(item);
            }
        }
        public static void PresentMenu()
        {
            //Warehouse.getInventory();
            //for warehouse class, should this open the stream?
            string dbpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filepath = dbpath + @"\Products.txt";
            using var fileStream = File.Open(filepath, FileMode.Open);
            using var streamReader = new StreamReader(fileStream);
            List<string> products = new List<string>();
            List<Product> productList = new List<Product>();
            while (!streamReader.EndOfStream)
            {
                products.Add(streamReader.ReadLine());

                foreach (string product in products)
                {

                    Console.WriteLine(product);
                }
                //don't close the stream until the user is done selecting their items
                //reopen stream if user wants to add to order
            }
        }
    }
}
