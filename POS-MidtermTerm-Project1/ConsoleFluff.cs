using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    internal class ConsoleFluff
    {
        public static void MakePrettyConsole()
        {
            Console.SetWindowSize(82, 40);
            Console.Title = "THE BURGER HUT II - Point of Sale Application";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
        }
    }
}
