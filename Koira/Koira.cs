using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Koira
{
	public class Koira : Elain
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

		// Override functions
		public override string ToString()
		{
			return $"Koira: {this.PalautaNimi()}, ikä {this.PalautaIka()}.";
		}
	}
}
