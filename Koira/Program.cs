using System;

namespace Koira
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira koira = new Koira();
            Console.WriteLine($"Nimen vaihto: {koira.AsetaKoiranNimi("Max")}");
            Console.WriteLine(koira);
            Console.WriteLine($"Nimen vaihto: {koira.AsetaKoiranNimi("Musti")}");
            Console.WriteLine(koira);

            Console.ReadKey();
        }
    }
}
