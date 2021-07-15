using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs Kurs1 = new Kurs();

            Kurs1.Kursadi = "C#";
            Kurs1.kursunegitmeni = "Engin Demiroğ";
            Kurs1.izlenmeorani = 68;

            Kurs Kurs2 = new Kurs();

            Kurs2.Kursadi = "Java";
            Kurs2.kursunegitmeni = "Ali Veli";
            Kurs2.izlenmeorani = 64;
            
            
            Kurs Kurs3 = new Kurs();

            Kurs3.Kursadi = "Phyton";
            Kurs3.kursunegitmeni = "Hasan Hüseyin";
            Kurs3.izlenmeorani = 80;

            Kurs[] kurslar = new Kurs[] { Kurs1, Kurs2, Kurs3 };

            foreach (var Kurs in kurslar)
            {
                Console.WriteLine(Kurs.Kursadi);
            }
             

            // Kurs türünde değişken tanımlıyoruz
            // Değişkeni elemanlandırıyoruz
            // Bu değişkenleri dizi altında topluyoruz
            // kurslar dizisindeki değişkenlerin elemanlarına erişiyoruz






        }
    }
    class Kurs
    {
        public string Kursadi { get; set; }
        public string kursunegitmeni { get; set; }
        sw
public int izlenmeorani { get; set; }

    }




}
