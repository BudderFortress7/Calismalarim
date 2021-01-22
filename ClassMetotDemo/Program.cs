using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager yardımcı = new MusteriManager();
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();
            Musteri musteri4 = new Musteri();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            musteri1.Ad = "Kerem";
            musteri1.Id = 684;
            musteri1.Soyad = "Demiralay";
            musteri1.Ad = "Kerem";
            yardımcı.Ekle(musteri1);
            yardımcı.Kaldır(musteri1);
            yardımcı.Listele(musteriler);
            Console.ReadLine();
        }
    }
}
