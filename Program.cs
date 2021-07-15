using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Kerimcan";
            musteri1.Soyadi = "Akçay";
            musteri1.Id = 196;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Selim";
            musteri2.Soyadi = "Akçay";
            musteri2.Id = 485;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Zülâl";
            musteri3.Soyadi = "Akçay";
            musteri3.Id = 986;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager MusteriM = new MusteriManager();
            MusteriM.Ekle(musteri1);
            MusteriM.Ekle(musteri2);
            MusteriM.Ekle(musteri3);

            Console.WriteLine("--------------------");

            MusteriM.Sil(musteri1);
            MusteriM.Sil(musteri2);
            MusteriM.Sil(musteri3);

            Console.WriteLine("--------------------");

            MusteriM.Listele(musteri1);
            MusteriM.Listele(musteri2);
            MusteriM.Listele(musteri3);

            Console.WriteLine("Müşteriler Listelenmiştir!");

        }
    }
}
