
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebarApplication.Models
{
    public class Invoice
    {
        public List<Order> orders { get; set; }
        public  double SumOrdersPrices { get; set; }// אחרי ההנחות!!! להוסיף משתנה עזר בהזמנה בשביל החישוב
        // כמות ההזמנות 
        //סכ
        public Invoice() { }
        //TODO פונקציה שמוסיפה הזמנה וגם מעדכנת את הסכום?
        // TODO פונקציה שמחשבת את הסיכום?
        public  void addOrder(Order order)
        {
            orders.Add(order);
            //חישוב של הסכום לפי הנחות 
        }
    }
}
