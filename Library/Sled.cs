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

        public bool AddGift(Gift gift)
        {
            foreach(Gift g in gifts)
            {
                maxVolume += g.weigth;
                maxVolume += g.volume;
            }
            if (maxWeigth < gift.weigth || maxVolume < gift.volume)
            {
                maxVolume = maxVolume - gift.volume;
                maxWeigth = maxWeigth - gift.weigth;
                gifts.Add(gift);
                return true;
            }
            else
            Console.Write("La slitta non puo reggere il peso dei regali");
            return false;          
        }
    }
    
}
