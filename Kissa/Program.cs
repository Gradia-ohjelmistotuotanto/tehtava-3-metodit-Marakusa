using System;

namespace Kissa
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa katti = new Kissa();

            Console.WriteLine($"Kissan nimi: {katti.nimi}");
            Console.WriteLine($"Nimen vaihto: {katti.AsetaKissanNimi("Anneli")}");
            Console.WriteLine($"Kissan nimi: {katti.nimi}");
            Console.WriteLine($"Nimen vaihto: {katti.AsetaKissanNimi("Hilda")}");
            Console.WriteLine($"Kissan nimi: {katti.nimi}");

            Console.ReadKey();
        }
    }
}
