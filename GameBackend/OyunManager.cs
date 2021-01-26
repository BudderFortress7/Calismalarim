using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend
{
    class OyunManager
    {
        public void SatınAl(Oyun oyun,Gamer gamer)
        {
            Console.WriteLine("Oyun başarıyla satın alındı ve faturan elektronik posta hesabına gönderildi "+gamer.Ad);
        }
        public void KampanyaKullan(Oyun oyun,Campaign campaign)
        {
            Console.WriteLine("Oyun kampanyanın getirdiği yüzde "+campaign.SalePercent+"'lik indirimle alındı.");
        }
    }
}
