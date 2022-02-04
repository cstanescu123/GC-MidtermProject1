using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    internal class Validator
    {
        public static bool ValidatePaymentStyle(string paymentMethod,string message, out string paymentType)
        {
           
            if (paymentMethod != "cash" && paymentMethod != "check" && paymentMethod!= "credit card")
            {
                Console.WriteLine(message);
                paymentType = null;
                return false;
            }
            paymentType = paymentMethod;
            return true;
        }
    }
}
