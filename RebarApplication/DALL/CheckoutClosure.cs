using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CheckoutClosure
    {
        public CheckoutClosure( Invoice invoice)
            // כניסה רק עם סיסמה
           
        {
            int ordersCount= invoice.orders.Count();
            double sumOrdersPrices= invoice.SumOrdersPrices;
            // להדפיס אותם

        }
        // מחשבת כמה הזמנות היו היום 
       //.היא לוקחת את זה מהמאגר ואת המספר מהחשבון
       //חוהדפסה של כל המחירים ביחד
    // יש את המידע הזה בחשבון


        //לשמור את הנתונים האלה במאגר לפי תאריך
    //
    }
}
