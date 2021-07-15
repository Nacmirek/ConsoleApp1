using System;

namespace Ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            Ev Ev1 = new Ev();
            Ev1.evinrengi = "Mavi ";
            Ev1.evinyasi = 6;
            Ev1.evinfiyati = 250000;

            Ev Ev2 = new Ev();
            Ev2.evinrengi = "Yeşil";
            Ev2.evinyasi = 11;
            Ev2.evinfiyati = 200000;

            Ev Ev3 = new Ev();
            Ev3.evinrengi = "Sarı ";
            Ev3.evinyasi = 18;
            Ev3.evinfiyati = 150000;

            Ev[] Evler = new Ev[] { Ev1, Ev2, Ev3, };

            Console.WriteLine("For Döngüsü");

            for (int i = 0; i < Evler.Length; i++)
            {
                Console.WriteLine("Evin Rengi= " + Evler[i].evinrengi + " / Evin Yaşı= " + Evler[i].evinyasi + " / Evin Fiyatı= " + Evler[i].evinfiyati);
            }

            Console.WriteLine("++++++++++++++++++++");

            Console.WriteLine("Foreach Döngüsü");

            foreach (var item in Evler)
            {
                Console.WriteLine("Evin Rengi= " + item.evinrengi + "/ Evin Yaşı= " + item.evinyasi + "/ Evin Fiyatı= " + item.evinfiyati);
            }

            Console.WriteLine("++++++++++++++++++++");

            Console.WriteLine("While Döngüsü");

            int a = 0;
            while (a < Evler.Length)
            {
                Console.WriteLine("Evin Rengi= " + Evler[a].evinrengi + " / Evin Yaşı= " + Evler[a].evinyasi + " / Evin Fiyatı= " + Evler[a].evinfiyati);
                a++;
            }



        }
    }

    class Ev
    {
        public string evinrengi;
        public int evinyasi;
        public int evinfiyati;
    }
}
