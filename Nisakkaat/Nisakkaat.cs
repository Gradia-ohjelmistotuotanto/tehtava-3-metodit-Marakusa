using ClassLibrary;
using System;


namespace Nisakkaat
{
    public abstract class Nisakkaat : Elain
    {
        private bool merinisäkäs = false;

        public void AsetaMerinisäkäs(bool merinisäkäs)
        {
            this.merinisäkäs = merinisäkäs;
        }

        public bool PalautaMerinisäkäs()
        {
            return this.merinisäkäs;
        }
        public string PalautaOnkoMerinisäkäs()
        {
            return this.merinisäkäs ? "Merinisäkäs" : "Ei ole merinisäkäs";
        }
    }
}
