using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    internal class CashRegister
    {
        public static double GetPaidInCash(double grandTotal)
        {
            double cashIn = 0; //amount user gave us in cash
            double cashOut = cashIn - grandTotal; 
          
            return Math.Round(cashOut, 2);
        }
        public static void GetPaidByCheck(double grandTotal)
        {
            Console.WriteLine("Please provide your three digit check number");
            
            Regex checkNumberPattern = new Regex(@"^\b([0-9][0-9][1-9])\b");
            if (!checkNumberPattern.IsMatch(Console.ReadLine()))
            {
                Console.WriteLine("Your check number is wrong. Please try again");
            }

            Console.WriteLine("Thank you paying us exactly what you owe.");
        }
        public static void GetPaidWithCreditCard(double grandTotal)
        {
            Console.WriteLine("Please input your card number.");
            Regex creditCardNumberPattern = new Regex(@"^\b\d{16}\b");
            if (!creditCardNumberPattern.IsMatch(Console.ReadLine()))
            {
                Console.WriteLine("This is bad credit card number, please provide us with the correct credit card number.");
            }

            Console.WriteLine("What is the experation date of your card? Format must be mm/yy.");
            Regex creditCardExpDatePattern = new Regex(@"^\b\d{ 2}/\d{ 2}\b");
            if (!creditCardExpDatePattern.IsMatch(Console.ReadLine()))
            {
                Console.WriteLine("You did not input the expiration date. The format is mm/yy.");
            }

            Console.WriteLine("Please enter the three digit CW code on the back of your card.");
            Regex creditCardCWPattern = new Regex(@"^\b\d{ 3}\b");
            if (!creditCardCWPattern.IsMatch(Console.ReadLine()))
            {
                Console.WriteLine("You did not input the expiration date. The format is mm/yy.");
            }

            Console.WriteLine("Thank you paying us exactly what you owe.");
        }
    }
}
