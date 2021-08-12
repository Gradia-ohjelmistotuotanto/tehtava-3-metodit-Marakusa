using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace Kissa
{
	public class Kissa : Nisakkaat.Nisakkaat
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

		public void Kehraa()
		{
			Console.WriteLine("hrrrrr");
		}

		public override void Aantele()
		{
			Console.WriteLine("Miau!");
		}

		// Override functions
		public override string ToString()
		{
			return $"Kissa: {this.PalautaNimi()}, ikä {this.PalautaIka()}, {(this.PalautaOnLihanSyoja() ? "Lihansyöjä" : "Ei ole lihansyöjä")}, {this.PalautaOnkoMerinisakas()}.";
		}
	}
}
