using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi " + musteri.Ad + " " + musteri.Soyad);
;       }
        public void Kaldır(Musteri musteri)
        {
            Console.WriteLine("Musteri kaldırıldı "+musteri.Ad+" "+musteri.Soyad);
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var i in musteriler)
            {
                Console.WriteLine(i.Ad);
            }
        }
    }
}
