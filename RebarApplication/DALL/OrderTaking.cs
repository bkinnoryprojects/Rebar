using Rebar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

/*
namespace DAL
{
    public class OrderTaking
    {
        //TODO עם API
        public OrderTaking()
        { }
        public void TakeOrder() { 
            //לקבל מהלקוח מידע
            //לא לשכוח בדיקותTODO !
            String CustomerName = "";//כנל
            List<string> DiscountsAndPromotions= new List<string>();//לבקש ממנו רשימה
            //ליצור רשימה מלולאה שמבקשת את זה
           // DiscountsAndPromotions = { }; TODO איך יוצרים רשימה ריקה? והאם כדאי לשלוח בכלל רשימה או רק במקרה שיש?
            Order order = new Order(CustomerName, DiscountsAndPromotions);
            bool flage=false;
            int Count = 0;
            // שיכניס הכל בבת אחת ואז אני יחלץ את זה אחד אחד...
            while (flage == true && Count<10)//איך מבקשים מהמשתמש להמשיך או להפסיק את ההזמונת?
            {
                string shakename = "";// וה APIחילוץ מהמונגו 

                string shakeSize = "";//כנל וENUM
                Shake shake = new Shake(shakename);//TODO  לפי זה לחלץ מהמסד נתונים מה שהתקבל מה API
                OrderdShake orderdShake= new OrderdShake(shake, shakeSize);
                Count++;
             //   flage = ; TODO איך אפשר לעשות שהוא מכיס כמה שהוא רוצה? איך יודעים להמשיך?
                order.addShakeToOrder(orderdShake);
                
            }
            closeOrder( order);

            // לא לשכוח לעדכן את זמן הסיום
            //TODO פונקציה שמעדכנת את המסד נתונים בסוף ההזמה
            //אפשר גם לקרוא לה ממחלקה אחרת
            //נאחד אותם ל]ונקציה אחת שנקראת סיום הזמנה
        }
        public void closeOrder(Order order)
        {
            order.closeTime();
            bool bill = false;
            while (bill == false)
            {
                Console.WriteLine("pleas pay");

                //  if (המשתנה שנכנס שווה למחיר או גבוה ממנו  )
                //bill==t
            }

            DatabaseInteraction.InsertOrderToDataBase(order);//איך מתפטרים מהשורה המעצבנת הזאת?
                                                                 //פונקציה שתוסיף את ההזמנה לחשבון 
           Invoice.addOrder(order);
            //TODO פונקתיה שמכניסה את ההזמנה למאגר
            
            // שאלה מתי בדיוק שמים את ההנחה? בפונקציה של החישוב ההכנסה?
        
        }

    }
}
*/