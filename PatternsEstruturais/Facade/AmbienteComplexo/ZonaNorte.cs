using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Facade.AmbienteComplexo
{
	public class ZonaNorte
	{
		public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
		{
			//Executa store procedure para itens vendas perdidas região NORTE - MY SQL
			Console.WriteLine("[!] - Executando complexidade rotina vendas perdidas região NORTE");

			return new List<object>();
		}
	}
}
