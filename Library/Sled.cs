using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Sled
    {
        double maxWeigth,maxVolume;
        List<Gift> gifts;
        public Sled(double maxVolume,double maxWeigth)
        {
            this.maxWeigth = maxWeigth;
            this.maxVolume = maxVolume;
            gifts = new List<Gift>();   
        }



        private bool AddGift()
        {
            double Weigth = 0;
            double Volume = 0;

            return true;
        }
    }
    
}
