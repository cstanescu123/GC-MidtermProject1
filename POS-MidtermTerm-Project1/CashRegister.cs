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
        //to call this method, the user needs to select cash
        public double GetPaidInCash(double grandTotal)
        {
            double cashIn = 0; //amount user gave us in cash
            double cashOut = cashIn - grandTotal; 
            
            if (cashIn < grandTotal)
            {
                //request more money (alternate payment method)
            }            
            return Math.Round(cashOut, 2);
        }

        //to call this method, the user needs to selec check
        public void GetPaidByCheck(double grandTotal)
        {
            Console.WriteLine("Please provide your three digit check number");
            
            Regex checkNumberPattern = new Regex(@"^\b([0-9][0-9][1-9])\b");
            if (!checkNumberPattern.IsMatch(Console.ReadLine()))
            {
                Console.WriteLine("Your check number is wrong.");
            }

            string checkNumber = Console.ReadLine(); //regex check number (verify)
            double checkAmount = 0; //amount user gave us in cash
           
            if (checkAmount < grandTotal)
            {
                //request more money (alternate payment method)
            }
            Console.WriteLine("Thank you paying us exactly what you owe");
        }

        //to select this method, user needs to select credit card
        public void GetPaidWithCreditCard(double grandTotal)
        {
            Regex creditCardPattern = new Regex(@"^\b([0-9][0-9][1-9])\b");
            if (!creditCardPattern.IsMatch(Console.ReadLine()))
            {
                Console.WriteLine("This is bad credit card number");
            }

            Console.WriteLine("Me asking for the credit card number, exp date, CW");
            double creditAmount = 0; //amount user gave us in cash

            if (creditAmount < grandTotal)
            {
                //request more money (alternate payment method)
            }

            Console.WriteLine("Thank you paying us exactly what you owe");
        }
    }
}
