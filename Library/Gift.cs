using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    
    public class Gift
    {
        public double weigth, volume;
        private string description, color;
         public Gift(string description,string color,double weigth, double volume)
        {
            this.weigth = weigth;
            this.volume = volume;
            this.description = description; 
            this.color = color;
        }
    }
}
