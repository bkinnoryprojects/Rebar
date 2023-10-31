using Rebar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using MongoDB.Bson;
using MongoDB.Driver;


namespace DAL

{
    public class DatabaseInteraction
    {
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<BsonDocument> collection;

        public DatabaseInteraction()
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "FinanceDB";
            string collectionName = "FinancialTransactions";

            client = new MongoClient(connectionString);
            database = client.GetDatabase(databaseName);
            collection = database.GetCollection<BsonDocument>(collectionName);
        }

        public IMongoCollection<BsonDocument> GetCollection()
        {
            return collection;
        }
        public void InsertOrderToDataBase(Order order) { }// TODO 
                                                                 // priceAfterDiscunt(); אולי נחשב בהזמנה?
        /*חוץ מלעשות את זה תחשבי את המחיר אחרי ההנחה
        }לאחר שהלקוח משלם, הגיע הזמן לכתוב את ההזמנה להזמנות שעשיתם כלהיום. 
        תחילה, צרו מאגר MongoDB שיכיל את כל ההזמנות של הסניף.
        על כל הזמנה במאגר, יהיה Order שיכיל את השדות הבאים: 
        • זמן יצירת ההזמנה 
        • זמן סיום הכנת ההזמנה 
        • מזהי כל השייקים בהזמנה 
        • סכום המחירים של כל השייקים בהזמנה
        • מזהה הזמנה 
        • שם הלקוח 
        בכל פעם שהסתיימה הזמנה, הכניסו אותה למאגר
        */

        // וכמובן להציג הודעה למשתמש מה קרה אם זה הצליח או לא
        // לעדכן את החשבון? מי מעדכן? אחרי הזמנה חדשה
    }
}
