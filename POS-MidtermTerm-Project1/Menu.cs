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
            List<Product> products = Warehouse.getInventory();
            foreach (var product in products)
            {
                Console.WriteLine($"[{product.ProductID}] {product.Name} {product.Description} {product.Category} ${product.Price}");
            }
            Console.WriteLine("");
            return products;
        }

        public static List<CartItem> SelectItemsForCart(List<Product> products, string message)
        {
            var cart = new List<CartItem>();
            Console.WriteLine(message); //asking user to select items based on xx (numbers)
            var cartItem = new CartItem(); //this will store the order
              int number = int.Parse(Console.ReadLine()); //this takes in our 2 digit code               
              if (!products.Any(x => x.ProductID == number))
              {
                  Console.WriteLine("That product does not exist in our amazing inventory");
              }
              else
              {
                  cartItem.Product = CartAction.GetProductByProductId(number);
                  Console.WriteLine($"How many {cartItem.Product.Name.Trim()}s would you like?");
                  cartItem.Quantity = int.Parse(Console.ReadLine()); //user give qty
                  cart.Add(cartItem);
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
    }
}
