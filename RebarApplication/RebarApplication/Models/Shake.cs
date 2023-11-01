using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace RebarApplication.Models
{
    public class Shake
    {
       // [BsonId]
      //  public ObjectId Id { get; set; }

        public string Name { get; set; }//TODO לעשות מתוך התפריט איכשהו
        public string Description { get; set; }// להביא מהבסיס נתונים

        public double SizeSPrice { get; set; }
        public double SizeMPrice { get; set; }
        public double SizeLPrice { get; set; }
        public Guid ShakeId { get; set; }

        public Shake(string Name) { 
            this.Name = Name;
            this.SizeSPrice=SizeSPrice;//להכניס מהדאטה בייס
            this.SizeMPrice=SizeMPrice;
            this.SizeLPrice = SizeLPrice;
            //TODO? או שעדיף שבלקחת הזמנה נטפל בהוצאה? להכניס מהדאטא בייס
        }
    }

    
}
