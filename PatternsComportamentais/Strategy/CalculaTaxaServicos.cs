using DesignPatterns.PatternsComportamentais.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Strategy
{
	public class CalculaTaxaServicos
	{
		public void Calcular(List<IServico> servicos)
		{
			foreach (IServico servico in servicos)
			{
				servico.CalcularServico();
                Console.WriteLine(new String('-', 40));
            }
		}
	}
}
