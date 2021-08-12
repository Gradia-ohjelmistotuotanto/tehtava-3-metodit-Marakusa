using System;
using System.Collections.Generic;
using System.Text;

namespace Kissa
{
	public class Kissa
	{
		private int ika;
		public string nimi;

		public Kissa()
		{
			this.ika = 0;
			this.nimi = "Miuku";
		}
		public Kissa(int ika, string nimi)
		{
			this.ika = ika;
			this.nimi = nimi;
		}

		/// <summary>
		/// Asettaa kissalle uuden nimen.
		/// </summary>
		/// <param name="nimi">Kissan uusi nimi.</param>
		/// <returns></returns>
		public bool AsetaKissanNimi(string nimi)
		{
			if (nimi.ToLower() != "hilda")
			{
				this.nimi = nimi;
				return true;
			}

			return false;
		}
		public bool AsetaKissanIka(int ika)
		{
			if (ika >= 0)
			{
				this.ika = ika;
				return true;
			}

			return false;
		}

		// Override functions
		public override string ToString()
		{
			return $"Kissa: {this.nimi}, ikä {this.ika}.";
		}
	}
}
