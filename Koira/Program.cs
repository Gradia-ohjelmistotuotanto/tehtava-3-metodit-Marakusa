using System;

namespace Koira
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira koira = new Koira();
            Console.WriteLine($"Nimen vaihto: {koira.AsetaNimi("Max")}");
            Console.WriteLine(koira);
            Console.WriteLine($"Nimen vaihto: {koira.AsetaNimi("Musti")}");
            Console.WriteLine(koira);

            Console.ReadKey();
        }
    }
}
