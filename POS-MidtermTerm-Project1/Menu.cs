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

        public static List<Product> ShowMenu(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("");
            List<Product> inventory = Warehouse.getInventory();
            foreach (var product in inventory)
            {
                Console.WriteLine($"[{product.ProductID}] {product.Name} {product.Description} {product.Category} ${product.Price}");
            }
            Console.WriteLine("");
            return inventory;
        }

        public static List<CartItem> SelectItemsForCart(Product product, string message)
        {
            var cart = new List<CartItem>();
            Console.WriteLine(message); //asking user to select items based on xx (numbers)
            bool anotherOrder = true;
            while (anotherOrder)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == product.ProductID)
                {
                    var cartItem = new CartItem();
                    Console.WriteLine("How many?");
                    cartItem.Quantity = int.Parse(Console.ReadLine());
                    cartItem.Product = product;

                    cart.Add(cartItem);
                }
                else
                {
                    Console.WriteLine("That product does not exist in our amazing inventory");
                }
                Console.WriteLine("Would you like to order something else? (yes/no)");
                string orderAgain = Console.ReadLine().Trim().ToLower();
                if (orderAgain == "yes")
                {
                    anotherOrder = true;
                    Console.WriteLine("");
                }
                else
                {
                    anotherOrder = false;
                    Console.WriteLine("");
                }
            }
            return cart;
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
