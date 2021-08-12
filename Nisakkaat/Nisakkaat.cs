using ClassLibrary;
using System;


namespace Nisakkaat
{
    public abstract class Nisakkaat : Elain
    {
        private bool merinisakas = false;

        public void AsetaMerinisakas(bool merinisakas)
        {
            this.merinisakas = merinisakas;
        }

        public bool PalautaMerinisakas()
        {
            return this.merinisakas;
        }
        public string PalautaOnkoMerinisakas()
        {
            return this.merinisakas ? "Merinisäkäs" : "Ei ole merinisäkäs";
        }
    }
}
