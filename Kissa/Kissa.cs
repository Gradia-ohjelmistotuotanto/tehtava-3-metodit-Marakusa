using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace Kissa
{
	public class Kissa : Elain
	{
		public Kissa()
		{
			this.AsetaNimi("Miuku");
		}
		public Kissa(int ika, string nimi)
		{
			this.AsetaIka(ika);
			this.AsetaNimi(nimi);
		}

		// Override functions
		public override string ToString()
		{
			return $"Kissa: {this.PalautaNimi()}, ikä {this.PalautaIka()}.";
		}
	}
}
