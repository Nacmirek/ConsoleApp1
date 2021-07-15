using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax - yazım şekilleri

        public void Ekle(Urun urun) //voidle komut oluşturuyoruz.
        {
            Console.WriteLine(urun.Adi + " Sepete Eklendi!");
        }

        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int stokAdedi)
        {
            Console.WriteLine(urunAdi + " Sepete Eklendi!");
        }








    }
}
