using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Rebar
{
    public class Order
    {
        public List<OrderdShake> Shakes { get; set; }
        public double TotalAmount { get; set; }
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public List<string> DiscountsAndPromotions { get; set; }// TODOמאיפה??
        public DateTime timeOrderStart { get; set; }
        public DateTime timeOrderEnd { get; set; }
        public TimeSpan Orderduration { get; set; }
        //TODO להוסיף הנחות לבנאי איכשהו

        public Order(string CustomerName, List<string> DiscountsAndPromotions)
        {
            this.OrderId = new Guid();
            this.CustomerName = CustomerName;
            this.OrderDate = DateTime.Now;
            this.Shakes=new List<OrderdShake>();
           // this.Shakes.Add(shakes);
            this.timeOrderStart = DateTime.Now;
            if (DiscountsAndPromotions!=null) {// TODO לבדוק בצורה יותר טובה
                this.DiscountsAndPromotions = DiscountsAndPromotions;
            }
            
        }
        public void addShakeToOrder(OrderdShake orderdShake)//TODO להוסיף שהיא זורקת חריגה
        {
            //  ..TODO בדיקות
            Shakes.Add(orderdShake);
            TotalAmount += orderdShake.shakeCost;

        }
       public void closeTime()
        {
            timeOrderEnd= DateTime.Now;
            Orderduration = timeOrderEnd - timeOrderStart;
        }
        // פונק שמחשבת את הזמן
        // פונקציה שנקראת אם מסיימים את ההזמנה והיא מעדכנת את השעה של הסיום ושל המשך זמן


    }
    // priceAfterDiscunt();

}

