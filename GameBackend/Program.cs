using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Ad = "Aslıhan";
            OyunManager oyunManager = new OyunManager();
            Campaign campaign = new Campaign {SalePercent = 25};
            Oyun oyun = new Oyun();
            oyunManager.SatınAl(oyun, gamer1);
            oyunManager.KampanyaKullan(oyun, campaign);
            Console.ReadLine();
        }
    }
}
