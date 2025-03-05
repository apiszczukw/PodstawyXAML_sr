using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PodstawyXAML_sr
{
	public class XmlHelper
	{
		public static void SerializeToXml<T>(T obj, string filePath)
		{
			var xml = new XmlSerializer(typeof(T));

			using (var writer = new StreamWriter(filePath))
			{
				xml.Serialize(writer, obj);
			}

		}
	}
}
