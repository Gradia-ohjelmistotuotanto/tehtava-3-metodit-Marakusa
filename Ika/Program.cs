using System;

namespace Ika
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Koira.Koira koira = new Koira.Koira();
                Kissa.Kissa kissa = new Kissa.Kissa();

                Random random = new Random();

                koira.AsetaIka(random.Next(1, 15));
                kissa.AsetaIka(random.Next(1, 10));

                int koiranIka = koira.PalautaIka();
                int kissanIka = kissa.PalautaIka();

                Console.WriteLine($"Koira on {koiranIka} vuotta, Kissa on {kissanIka} vuotta");

                if (koiranIka > kissanIka)
                    Console.WriteLine("Koira on vanhempi");
                else if (koiranIka < kissanIka)
                    Console.WriteLine("Kissa on vanhempi");
                else
                    Console.WriteLine("Samanikäiset");
            }

            Console.ReadKey();
        }
    }
}
