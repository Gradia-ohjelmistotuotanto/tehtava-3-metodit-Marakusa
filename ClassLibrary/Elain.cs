using System;

namespace ClassLibrary
{
    public abstract class Elain
    {
		private int ika = 0;
        private string nimi;
		private bool onLihanSyoja = false;

		/// <summary>
		/// Laita eläin äännähtämään
		/// </summary>
		public virtual void Aantele()
		{
			Console.WriteLine("Umph!");
		}

		/// <summary>
		/// Asettaa eläimelle uuden nimen.
		/// </summary>
		/// <param name="nimi">Kissan uusi nimi.</param>
		/// <returns></returns>
		public bool AsetaNimi(string nimi)
		{
			this.nimi = nimi;
			return true;
		}
		/// <summary>
		/// Asettaa eläimelle uuden iän.
		/// </summary>
		/// <param name="ika">Eläimen uusi ikä.</param>
		/// <returns></returns>
		public bool AsetaIka(int ika)
		{
			if (ika >= 0)
			{
				this.ika = ika;
				return true;
			}

			return false;
		}
		/// <summary>
		/// Asettaa onko eläin lihan syöjä.
		/// </summary>
		/// <param name="onLihanSyoja">Onko lihan syöjä.</param>
		/// <returns></returns>
		public bool AsetaOnLihanSyoja(bool onLihanSyoja)
		{
			this.onLihanSyoja = onLihanSyoja;
			return true;
		}

		/// <summary>
		/// Palauttaa eläimen iän.
		/// </summary>
		public int PalautaIka()
		{
			return this.ika;
		}
		/// <summary>
		/// Palauttaa eläimen nimen.
		/// </summary>
		public string PalautaNimi()
		{
			return this.nimi;
		}
		/// <summary>
		/// Palauttaa onko eläin lihan syöjä.
		/// </summary>
		public bool PalautaOnLihanSyoja()
		{
			return this.onLihanSyoja;
		}
		/// <summary>
		/// Palauttaa onko eläin lihan syöjä string muodossa.
		/// </summary>
		public string OnkoLihanSyoja()
		{
			return this.onLihanSyoja ? "Lihan syöjä" : "Ei ole lihan syöjä";
		}
	}
}
