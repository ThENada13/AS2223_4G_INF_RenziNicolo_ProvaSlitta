using Library;

namespace AS2223_4G_INF_RenziNicolo_ProvaSlitta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sled r = new Sled(26,39);
            r.AddGift(new Gift("palla","nera",13,13));
        }
    }
}