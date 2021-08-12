using System;
using System.Collections.Generic;
using System.Text;

namespace Koira
{
	public class Koira
	{
		private int ika;
		public string nimi;

		public Koira()
		{
			this.ika = 0;
			this.nimi = "Haukkuli";
		}
		public Koira(int ika, string nimi)
		{
			this.ika = ika;
			this.nimi = nimi;
		}

		/// <summary>
		/// Asettaa koiralle uuden nimen.
		/// </summary>
		/// <param name="nimi">Koiran uusi nimi.</param>
		/// <returns></returns>
		public bool AsetaKoiranNimi(string nimi)
		{
			if (nimi.ToLower() != "musti")
			{
				this.nimi = nimi;
				return true;
			}

			return false;
		}
		public bool AsetaKoiranIka(int ika)
		{
			if (ika >= 0)
			{
				this.ika = ika;
				return true;
			}

			return false;
		}

		public int PalautaKoiranIka()
		{
			return ika;
		}

		// Override functions
		public override string ToString()
		{
			return $"Koira: {this.nimi}, ikä {this.ika}.";
		}
	}
}
