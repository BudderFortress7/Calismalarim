using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend
{
    class GamerManager
    {
        public void Ekle(Gamer gamer)
        {
            GamerEDevletKontrol gamerEDevletKontrol = new GamerEDevletKontrol();
            if (gamerEDevletKontrol.KontrolEt(gamer)==true)
            {
                Console.WriteLine("Kaydın yapıldı "+gamer.Ad);
            }
            else
            {
                Console.WriteLine("Müşteri bilgilerini kontrol ediniz.");
            }
        }
        public void Güncelle(Gamer gamer)
        {
            Console.WriteLine("Bilgileriniz güncellendi");
        }
        public void Sil(Gamer gamer)
        {
            Console.WriteLine("Profiliniz Silindi");
        }
        

        
    }
}
