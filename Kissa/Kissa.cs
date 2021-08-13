using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace Kissa
{
	public class Kissa : Nisakkaat.Nisakkaat
	{
		private readonly string[] kissanNimet = new string[] { "Miuku", "Akka", "Lutu", "Roope", "Aliisa", "Pirre", "Purre", "Unto", "Lillu" };
		public string[] Nimet
        {
			get
            {
				return kissanNimet;
            }
        }

		private List<Kissa> pennut = new List<Kissa>();
		private Kissa emo = null;

		public Kissa(int ika = 0, string nimi = "Miuku", Kissa emo = null)
		{
			this.AsetaIka(ika);
			this.AsetaNimi(nimi);
			this.emo = emo;
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
			return $"Kissa: {this.PalautaNimi()}," +
				$" ikä {this.PalautaIka()}," +
				$" {(this.PalautaOnLihanSyoja() ? "Lihansyöjä" : "Ei ole lihansyöjä")}," +
				$" {this.PalautaOnkoMerinisakas()}," +
				$" {(this.emo == null ? "Emo tuntematon" : "Emo: " + this.emo.PalautaNimi())}.";
		}

		public int LisääPentu(string nimi, int ika = 0)
		{
			Kissa pentu = new Kissa(ika, nimi, this);
			pentu.AsetaNimi(nimi);
			pentu.AsetaOnLihanSyoja(true);

			pennut.Add(pentu);

			return pennut.Count;
		}
		public List<Kissa> Pennut()
		{
			return pennut;
		}

		public void LuoSukupolvia(int sukupolvet, int aloitus = -1)
        {
			if (aloitus == -1)
				aloitus = sukupolvet;

			if (sukupolvet > 0)
			{
				sukupolvet--;

				Random random = new Random();
				int maara = random.Next(1, 5);

				for (int i = 0; i < maara; i++)
				{
					int id = LisääPentu(Nimet[random.Next(0, Nimet.Length - 1)]);

					string polvivali = "";

					for (int vali = 0; vali < aloitus - sukupolvet; vali++)
						polvivali += "    ";

					Console.WriteLine(polvivali + pennut[id - 1]);

					pennut[id - 1].LuoSukupolvia(sukupolvet, aloitus);
				}
			}
        }
	}
}
