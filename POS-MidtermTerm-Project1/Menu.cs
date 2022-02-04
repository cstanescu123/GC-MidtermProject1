using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    //User has option to select a product to add to cart
    //Welcome user, ask for name
    //User selects payment style
    
    

    public class Menu
    {
        //Welcome user and get their information
        public static string Welcome()
        {
            Console.WriteLine("Hello! Welcome the greatest cafe ever!");
            Console.Write("Please tell me your name: ");
            string userName = Console.ReadLine(); //Do we want to test for null?
            Console.WriteLine($"Welcome {userName}!"); //maybe return userName for this method so we can use it else where
            return userName;
        }
 
        //Menu needs to show list of products
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
            }
        }

        public static string AskForPayment()
        {
            Console.WriteLine("How would you like to pay for your awesome items?");
            Console.WriteLine("Cash, Check, or Credit Card?");                        
            string userPaymentMethod = Console.ReadLine();

            if (userPaymentMethod != "cash" || userPaymentMethod != "check" || userPaymentMethod != "credit card")
            {
                Console.WriteLine("Please enter a valid payment type.");
            } //make validation method
            return userPaymentMethod;
        }

        public void ShowReceipt()
        {
            //Get method for receipt class
            string receipt = "yes";
            Console.WriteLine(receipt); //this is where we will output the receipt
        }



    }
}
