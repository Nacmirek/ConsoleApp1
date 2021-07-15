using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yaızılım geliştirici yetiştirme kampı";
            string kurs2 = "proglamlamaya başlangıç temel kurs";
            string kurs3 = "java";

            for (int i = 0; i < kurslar.Length; i++)               // i+=2 şeklinde de yazabiliyoruz  // for - tek seferli döngü
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Bitti");

            // (int i = 0;): Başlangıç değeri,
            // (i<kurslar.Lenght;): Tanım aralığı
            // (i++/i+=2): Artış miktarı
            // (kurslar[i]): kurslar kümesinin elemanları
            // array - dizi
            // Length - herhangi bir grubun uzunluğu, eleman miktarı



            string[] kurslar = new string[] {"yaızılım geliştirici yetiştirme kampı","proglamlamaya başlangıç temel kurs","java" };
            // dizi oluşturma
            // (string[] kurslar = new string): string tanımladığımız dizinin türü, kurslar dizinin adı
            // {"yaızılım geliştirici yetiştirme kampı","proglamlamaya başlangıç temel kurs","java" }; 
            // Kısmı ise dizinin elemanları

            foreach (string kurs in kurslar)     
            {
                Console.WriteLine(kurs);
            }


            // Kurslar dizisinin string elemanlarını kurs olarak tanımlayıp onları yazdırıyoruz
            // for daha genel * forreach dizileri daha kolay dolaşmak için















        }
    }
}
