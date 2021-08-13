using System;

namespace Papukaija
{
    public class Papukaija : Linnut.Linnut
	{
		public readonly string[] papukaijanNimet = new string[] { "Mango", "Kaija", "Papu", "Sini", "Volcano", "Angel", "Boris", "Earl", "Egor" };
		public string[] Nimet
		{
			get
			{
				return papukaijanNimet;
			}
		}


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
