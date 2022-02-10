using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    internal class TryValidate
    {
        public static bool GetValidation(string message)
        {
            Console.WriteLine(message);
            string choice = Console.ReadLine().Trim().ToLower();
            if (choice == "y")
          {
              return true;
          }
          else
          {
             return false;
          }
            Console.WriteLine("");
        }        
    }
}
