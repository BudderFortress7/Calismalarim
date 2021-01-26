using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend
{
    class CampaignManager
    {
        public void Ekle()
        {
            Console.WriteLine("Kampanya Eklendi");
        }
        public void Sil(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }
        public void Guncelle(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellenmiştir.");
        }
    }
}
