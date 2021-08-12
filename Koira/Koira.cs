using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Koira
{
	public class Koira : Nisakkaat.Nisakkaat
	{
		public Koira()
		{
			this.AsetaNimi("Haukkuli");
		}
		public Koira(int ika, string nimi)
		{
			this.AsetaIka(ika);
			this.AsetaNimi(nimi);
		}

		public override void Aantele()
		{
			Console.WriteLine("Hau!");
		}

		// Override functions
		public override string ToString()
		{
			return $"Koira: {this.PalautaNimi()}, ikä {this.PalautaIka()}.";
		}
	}
}
