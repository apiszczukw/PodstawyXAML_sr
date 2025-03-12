using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PodstawyXAML_sr.Klasy
{
	public class Osoba
	{
		[XmlAttribute("lp")]
		public int Lp;

		[XmlAttribute("nazwisko")]
		public string Nazwisko;

		[XmlAttribute("imię")]
		public string Imie;

		[XmlAttribute("rok")]
		public int Rok;

		[XmlAttribute("dojazd")]
		public string Dojazd;

		[XmlAttribute("kierunek")]
		public string Kierunek;

		[XmlAttribute("stypendium")]
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
