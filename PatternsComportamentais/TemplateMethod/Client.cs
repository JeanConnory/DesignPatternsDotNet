using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.TemplateMethod
{
	public class Client
	{
		public void ConsumirEndpointXML()
		{
            Console.WriteLine("\n__________XML__________\n");

			var xml = ObtemDadosAPI.EndpointXML();
			ConvertXML convertXML = new ConvertXML(xml);

			convertXML.ProcessarXML();
        }

		public void ConsumirEndpointJSON()
		{
			Console.WriteLine("\n__________JSON__________\n");

			var json = ObtemDadosAPI.EndpointJSON();
			ConvertJSON convertJSON = new ConvertJSON(json);

			convertJSON.ProcessarJSON();
		}
	}
}
