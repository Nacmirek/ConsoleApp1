using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " adındaki " + musteri.Id + " Id'li Müşteri Eklendi!"); 
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + musteri.Id);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " adındaki " + musteri.Id + " Id'li Müşteri Silindi!");
        }

    }
}
