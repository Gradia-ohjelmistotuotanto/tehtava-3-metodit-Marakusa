using System;

namespace Papukaija
{
    public class Papukaija : Linnut.Linnut
	{
		public Papukaija()
		{
			this.AsetaNimi("Kalle");
		}

		// Override functions
		public override string ToString()
		{
			return $"Papukaija: {this.PalautaNimi()}, ikä {this.PalautaIka()}, {(this.PalautaOnLihanSyoja() ? "Lihansyöjä" : "Ei ole lihansyöjä")}.";
		}
	}
}
