﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PodstawyXAML_sr.Klasy
{
	public class Przedmiot
	{
		[XmlAttribute("nazwa")]
		public string Nazwa;

		[XmlAttribute("ileGodzin")]
		public int IleGodzin;
	}
}
