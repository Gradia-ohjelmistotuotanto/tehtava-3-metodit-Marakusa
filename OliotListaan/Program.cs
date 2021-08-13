using ClassLibrary;
using System;
using System.Collections.Generic;

namespace OliotListaan
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        koira.AsetaNimi(koira.Nimet[random.Next(0, koira.Nimet.Length - 1)]);
                        koira.AsetaOnLihanSyoja(random.Next(0, 1) == 1);
                        koira.AsetaMerinisakas(false);
                        Console.WriteLine(koira);
                        break;
                    case 1:
                        Kissa.Kissa kissa = new Kissa.Kissa();
                        kissa.AsetaIka(random.Next(1, 15));
                        kissa.AsetaNimi(kissa.Nimet[random.Next(0, kissa.Nimet.Length - 1)]);
                        kissa.AsetaOnLihanSyoja(random.Next(0, 1) == 1);
                        kissa.AsetaMerinisakas(false);
                        Console.WriteLine(kissa);
                        break;
                    case 2:
                        Papukaija.Papukaija papukaija = new Papukaija.Papukaija();
                        papukaija.AsetaIka(random.Next(1, 15));
                        papukaija.AsetaNimi(papukaija.Nimet[random.Next(0, papukaija.Nimet.Length - 1)]);
                        papukaija.AsetaOnLihanSyoja(random.Next(0, 1) == 1);
                        Console.WriteLine(papukaija);
                        break;
                }
            }
        }
    }
}
