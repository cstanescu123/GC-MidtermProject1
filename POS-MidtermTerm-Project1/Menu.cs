using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{    
    public class Menu
    {       
        public static string Welcome()
        {
            Console.WriteLine("Hello! Welcome the greatest cafe ever!");
            Console.Write("Please tell me your name: ");
            string userName = Console.ReadLine(); //Do we want to test for null?
            Console.WriteLine($"Welcome {userName}!");
            return userName;
        }        
        public static void PresentMenu()
        {
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
        public static List<Product> SelectItems()
        {
            Console.WriteLine("Please select the food you wish to each");
            List<Product> userOrder = new List<Product>();
            //validate user selection (let's make this numberical ordering?)
            //should we call the cart item function here?
            return userOrder;            
        }
        public static string AskForPayment() //method does not work as intended
        {
            bool userContinue = false;
            string paymentType;
            string userPaymentMethod;
                Console.WriteLine("How would you like to pay for your awesome items?");
                Console.WriteLine("Cash, Check, or Credit Card?");                        
                userPaymentMethod = Console.ReadLine().Trim().ToLower();
            while (!userContinue)
            {
            
                userContinue = Validator.ValidatePaymentStyle(userPaymentMethod, "Please select a valid payment method.", out paymentType);               
                return userPaymentMethod = paymentType;
            }            
            return userPaymentMethod;  //this doesn't return as needed
        }
        public void ShowReceipt(List<string> receipt)
        {         
            foreach (var item in receipt)
            {
                Console.WriteLine(item);
            }            
        }


    }
}
