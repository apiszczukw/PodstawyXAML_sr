using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyXAML_sr.Klasy
{
	internal class Osoba
	{
		public int Lp;

		public string Nazwisko;

		public string Imie;

		public int Rok;

		public string Dojazd;

		public string Kierunek;

		public string Stypendium;

		public List<Przedmiot> Przedmioty;

		public Osoba()
		{
			Przedmioty = new List<Przedmiot>();
		}

		public Osoba(int lp, string nazwisko, string imie, int rok, string dojazd, string kierunek, string stypendium, List<Przedmiot> przedmioty)
		{
			Lp = lp;
			Nazwisko = nazwisko;
			Imie = imie;
			Rok = rok;
			Dojazd = dojazd;
			Kierunek = kierunek;
			Stypendium = stypendium;
			Przedmioty = przedmioty;
		}

		public override string ToString()
		{
			return "Witaj " + Imie + " " + Nazwisko;
		}
	}
}
