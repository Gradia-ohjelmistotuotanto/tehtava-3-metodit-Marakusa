using System;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa.Kissa kissa = new Kissa.Kissa();

            kissa.AsetaNimi("Pätkä");
            kissa.AsetaIka(6);
            kissa.AsetaOnLihanSyoja(false);

            Console.WriteLine($"{kissa.PalautaNimi()}, {kissa.PalautaIka()}, {kissa.OnkoLihanSyoja()}");

            kissa.Aantele();


            Koira.Koira koira = new Koira.Koira();

            koira.AsetaNimi("Hilda");
            koira.AsetaIka(9);
            koira.AsetaOnLihanSyoja(true);

            Console.WriteLine($"{koira.PalautaNimi()}, {koira.PalautaIka()}, {koira.OnkoLihanSyoja()}");

            koira.Aantele();


            Console.ReadKey();
        }
    }
}
