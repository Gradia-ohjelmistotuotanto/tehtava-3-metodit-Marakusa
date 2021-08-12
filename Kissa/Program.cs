using System;

namespace Kissa
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa katti = new Kissa();

            Console.WriteLine(katti);
            Console.WriteLine($"Nimen vaihto: {katti.AsetaKissanNimi("Anneli")}");
            Console.WriteLine(katti);
            Console.WriteLine($"Nimen vaihto: {katti.AsetaKissanNimi("Hilda")}");
            Console.WriteLine(katti);

            Console.ReadKey();
        }
    }
}
