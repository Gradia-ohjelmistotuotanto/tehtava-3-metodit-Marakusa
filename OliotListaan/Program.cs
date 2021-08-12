using ClassLibrary;
using System;
using System.Collections.Generic;

namespace OliotListaan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] koiranNimet = new string[] { "Musti", "Hilda", "Max", "Pontus", "Papu", "Huntti", "Leo", "Neela", "Rekku" };
            string[] kissanNimet = new string[] { "Miuku", "Akka", "Lutu", "Roope", "Aliisa", "Pirre", "Purre", "Unto", "Lillu" };
            string[] papukaijanNimet = new string[] { "Mango", "Kaija", "Papu", "Sini", "Volcano", "Angel", "Boris", "Earl", "Egor" };

            int maara = -1;

            do
            {
                Console.Write("Anna generoitavien eläinten määrä: ");
                int.TryParse(Console.ReadLine(), out maara);
            }
            while (maara <= 0);

            Console.WriteLine($"Generoidaan {maara} eläintä...");

            Random random = new Random();

            for (int i = 0; i < maara; i++)
            {
                switch (i % 3)
                {
                    case 0:
                        Koira.Koira koira = new Koira.Koira();
                        koira.AsetaIka(random.Next(1, 15));
                        koira.AsetaNimi(koiranNimet[random.Next(0, koiranNimet.Length - 1)]);
                        koira.AsetaOnLihanSyoja(random.Next(0, 1) == 1);
                        koira.AsetaMerinisakas(false);
                        Console.WriteLine(koira);
                        break;
                    case 1:
                        Kissa.Kissa kissa = new Kissa.Kissa();
                        kissa.AsetaIka(random.Next(1, 15));
                        kissa.AsetaNimi(kissanNimet[random.Next(0, kissanNimet.Length - 1)]);
                        kissa.AsetaOnLihanSyoja(random.Next(0, 1) == 1);
                        kissa.AsetaMerinisakas(false);
                        Console.WriteLine(kissa);
                        break;
                    case 2:
                        Papukaija.Papukaija papukaija = new Papukaija.Papukaija();
                        papukaija.AsetaIka(random.Next(1, 15));
                        papukaija.AsetaNimi(papukaijanNimet[random.Next(0, papukaijanNimet.Length - 1)]);
                        papukaija.AsetaOnLihanSyoja(random.Next(0, 1) == 1);
                        Console.WriteLine(papukaija);
                        break;
                }
            }
        }
    }
}
