using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // do not repeat yourself
            // type safety
            // değer tutucu = alias

            string kategorietiketi = "kategori";
            int ogrencisayisi = 32000;
            double faizorani = 1.45;
            bool sistemegirisyapmismi = true;
            double dolardun = 7.35;
            double dolarbugun = 7.45;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("Azalış");
            }
            else if (dolardun<dolarbugun)
            {
                Console.WriteLine("Artış");
            }


            if (sistemegirisyapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }



            Console.WriteLine("Hello World!");

            Console.WriteLine("Merhaba");




        }
    }
}
