using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunadi = "Elma";
            double urununfiyati = 15;
            string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            // type safe -- tip güvenliği
            foreach (Urun Urun in urunler)
            {
                Console.WriteLine(Urun.Adi);
                Console.WriteLine(Urun.Fiyati);
                Console.WriteLine(Urun.Aciklama);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("----------Metotolar----------");
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yesil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yesil Elma", 12, 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 9);

        }
    }
}


// Don't repeat yourself - DRY - Clean Code - Best Practice