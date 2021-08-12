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
            kissa.AsetaOnLihanSyoja(true);

            kissa.OnkoMerinisäkäs(false);

            Console.WriteLine($"{kissa.PalautaNimi()}, {kissa.PalautaIka()}, {kissa.OnkoLihanSyoja()}, {kissa.PalautaMerinisäkäs()}");

            kissa.Aantele();


            Koira.Koira koira = new Koira.Koira();

            koira.AsetaNimi("Hilda");
            koira.AsetaIka(9);
            koira.AsetaOnLihanSyoja(true);

            koira.OnkoMerinisäkäs(false);

            Console.WriteLine($"{koira.PalautaNimi()}, {koira.PalautaIka()}, {koira.OnkoLihanSyoja()}, {koira.PalautaMerinisäkäs()}");

            koira.Aantele();


            Papukaija.Papukaija papukaija = new Papukaija.Papukaija();

            papukaija.AsetaNimi("Mango");
            papukaija.AsetaIka(2);
            papukaija.AsetaOnLihanSyoja(false);

            Console.WriteLine($"{papukaija.PalautaNimi()}, {papukaija.PalautaIka()}, {papukaija.OnkoLihanSyoja()}");

            papukaija.Aantele();
            papukaija.Lenna();


            Console.ReadKey();
        }
    }
}
