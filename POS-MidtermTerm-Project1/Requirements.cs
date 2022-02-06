using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MidtermTerm_Project1
{
    internal class Requirements
    {
        //REQUIREMENTS\\

        //Product/CartItem:
        ///Class (productID,name, category, description, price,productChar)
        ///Point to 12 products stored in csv .txt

        //Menu:
        ///Allow choice of item(by int or char)
        ///Allow user to choose quantity of item
        ///Allow method to return to the menu
        ///Allow create new order

        //Calculator:
        ///Output to user a line total (item price * quantity)
        ///Output the subtotal
        ///Output the sales tax
        ///Output the grand total

        //Cash Register:
        ///Input == grand total if not cash, if cash > grand total
        ///Input of Cash (amount tendered, provide change)
        ///Input of Check (get the check number)
        ///Input of Credit (get cc number, expiry, and CW )

        //Shopping Cart:
        ///contains n products
        ///resets after receipt created

        //Receipt:
        ///Output all items ordered
        ///Output subtotal
        ///Output grand total
        ///Output appropriate payment info
        ///Empty order and create new

    }
}
