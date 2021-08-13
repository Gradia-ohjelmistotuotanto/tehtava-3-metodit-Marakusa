using System;

namespace Hevonen
{
    public class Hevonen : Nisakkaat.Nisakkaat
	{
		public readonly string[] hevosenNimet = new string[] { "Hirnu", "Hepo", "Max", "Ella" };
		public string[] Nimet
		{
			get
			{
				return hevosenNimet;
			}
		}

		public Hevonen()
		{
			this.AsetaNimi("Haukkuli");
		}
		public Hevonen(int ika, string nimi)
		{
			this.AsetaIka(ika);
			this.AsetaNimi(nimi);
		}

		public override void Aantele()
		{
			Console.WriteLine("Hevonen hirnahtaa");
		}

		// Override functions
		public override string ToString()
		{
			return $"Hevonen: {this.PalautaNimi()}, ikä {this.PalautaIka()}, {(this.PalautaOnLihanSyoja() ? "Lihansyöjä" : "Ei ole lihansyöjä")}, {this.PalautaOnkoMerinisakas()}.";
		}
	}
}
