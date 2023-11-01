using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebarApplication.Models
{
    internal class ShakeForMenu
    {
        public string Name { get; set; }//TODO לעשות מתוך התפריט איכשהו
        public string Description { get; set; }// להביא מהבסיס נתונים

        public double SizeSPrice { get; set; }
        public double SizeMPrice { get; set; }
        public double SizeLPrice { get; set; }
        public string ShakeId { get; set; }

        public ShakeForMenu(string Name ,string Description,double SizeLPrice, double SizeMPrice, double SizeSPrice)
        {
            this.ShakeId= new Guid().ToString();    
            this.Name = Name;
            this.Description = Description;
            this.SizeSPrice = SizeSPrice;//להכניס מהדאטה בייס
            this.SizeMPrice = SizeMPrice;
            this.SizeLPrice = SizeLPrice;
        }
    }
}
