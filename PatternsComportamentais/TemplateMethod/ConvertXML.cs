using DesignPatterns.PatternsComportamentais.TemplateMethod.AbstractModel;
using DesignPatterns.PatternsComportamentais.TemplateMethod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatterns.PatternsComportamentais.TemplateMethod
{
	public class ConvertXML : ProcessaDados
	{
		public ConvertXML(string xml) : base(xml: xml) { }

		public override void ProcessarXML()
		{
			XmlSerializer serializer = new XmlSerializer(this.pessoas.GetType());

			var stringReader = new StringReader(this.xml);

			using (var reader = XmlReader.Create(stringReader))
			{
				this.pessoas = (List<Pessoa>)serializer.Deserialize(reader);
			}

			this.ApresentarValores();
		}
	}
}
