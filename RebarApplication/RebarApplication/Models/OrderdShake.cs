
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebarApplication.Models
{ 

    public class OrderdShake
    {
        public Shake shake { get; set; }
        public string shakeSize {  get; set; }//TODO לעשות כENUM
        public double shakeCost { get; set;}
        public OrderdShake( Shake shake, string shakeSize)
        {
            this.shake = shake;
            this.shakeSize = shakeSize;
        if (shakeSize == "L")
            this.shakeCost = shake.SizeLPrice;
        else if (shakeSize =="M")
            this.shakeCost= shake.SizeMPrice;
        else if(shakeSize =="S")
            this.shakeCost= shake.SizeSPrice;
       
        }
        // פונקציה שמחשבת את העלות 
      
    }
}
    

    