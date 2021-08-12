using ClassLibrary;
using System;


namespace Nisakkaat
{
    public abstract class Nisakkaat : Elain
    {
        private bool merinisäkäs = false;

        public void OnkoMerinisäkäs(bool merinisäkäs)
        {
            this.merinisäkäs = merinisäkäs;
        }

        public bool PalautaOnkoMerinisäkäs()
        {
            return this.merinisäkäs;
        }
        public string PalautaMerinisäkäs()
        {
            return this.merinisäkäs ? "Merinisäkäs" : "Ei ole merinisäkäs";
        }
    }
}
