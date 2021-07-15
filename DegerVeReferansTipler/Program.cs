using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; //değerini atadık
            sayi2 = 65;

            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] {};
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2; //adresini atadık
            sayilar2[0] = 999; 

            Console.WriteLine(sayilar1[0]);

            //int,decimal,floot,double,bool = değer tip,
            //array,class,intergare = referans tip,
            //stack - değer, heap - referans


        }
    }
}
