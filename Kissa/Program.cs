using System;

namespace Kissa
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa katti = new Kissa();

            Console.WriteLine(katti);
            Console.WriteLine($"Nimen vaihto: {katti.AsetaNimi("Anneli")}");
            Console.WriteLine(katti);
            Console.WriteLine($"Nimen vaihto: {katti.AsetaNimi("Hilda")}");
            Console.WriteLine(katti);

            Console.ReadKey();
        }
    }
}
