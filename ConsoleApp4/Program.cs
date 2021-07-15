using System;

namespace DersNotlari
{
    class Notlar

    {
        static void Main(string[] args)
        {

            // Ternary Operatörü: Şarta bağlı değer döndüren bir operatördür.
            // Döenecek değerler aynı türde olmalı - Polimorfizm birbirinden türeyen değerlerde desteklenmektedir
            // aynı türdeki işleri if ve else gibi şart bloklarından daha kısa satırda yapabilme kolaylığı sağlar

            bool medenihal = true;
            string mesaj = medenihal == true ? "Evlilere Kampanya" : "Bekarlara Kampanya" ;
            Console.WriteLine(mesaj);


            //-----------------------------------------------------------------------------------


            // switch/case: if-else koşul yapılarının alternatifidir. Yaptıkları işler aynıdır yapıları farklıdır.
            // Belirli bir tanım aralığı var ve tanım  aralığındaki girdiğiniz değerlere göre farklı sonuçlar alabiliriz.
            // Fakat tanım aralığında olmayan bir değeri girdiğimizde sadece tek bir yanıt oluyor. 
            // Switch ile değer giriyoruz. Switch'de girdiğimiz değer case'deki değerle eşleşirse o değere atadığımız komut çalışıyor ve break'le son buluyor;
            // ancak switch'de girdiğimiz değer case'deki değerlerle eşleşmediyse default devreye giriyor ve defaulta atadığımız komut çalışıyor.

            Console.Write("Hangi Ülkede Üretildiğiniz Öğrenmek İstediğiniz Aracın Markasını Yazınız:");
            string arac = Console.ReadLine();
            switch (arac)
            {
                case "BMW":
                    Console.WriteLine("ALMANYA");
                    break;
                case "AUDI":
                    Console.WriteLine("ALMANYA");
                    break;
                case "TOYOTA":
                    Console.WriteLine("JAPONYA");
                    break;
                case "HYUNDAI":
                    Console.WriteLine("GÜNEY KORE");
                    break;
                default:
                    Console.WriteLine("Nerede Üretildiği Bilinmiyor");
                    break;
            }

            //-----------------------------------------------------------------------------------


            //While döngüsünde parantez içine koşulu yazarız ve koşul sağlandığı sürece o döngü devam eder. Koşul sağlanmadığı zaman döngü sonlanır.

            int number = 10;
            while (number>0)
            {
                Console.WriteLine(number);
                number--;
            }

            //-----------------------------------------------------------------------------------

            
        }
    }
}
