using ClassLibrary;
using System;

namespace Linnut
{
    public abstract class Linnut : Elain
    {
        public override void Aantele()
        {
            Console.WriteLine("Squeek!");
        }

        public void Lenna()
        {
            Console.WriteLine("Lintu lentää.");
        }
    }
}
