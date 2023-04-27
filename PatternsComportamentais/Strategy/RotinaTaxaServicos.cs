using DesignPatterns.PatternsComportamentais.Strategy.Enum;
using DesignPatterns.PatternsComportamentais.Strategy.Interfaces;
using DesignPatterns.PatternsComportamentais.Strategy.Model;
using DesignPatterns.PatternsComportamentais.Strategy.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Strategy
{
	public class RotinaTaxaServicos
	{
		public void ExecutarRotina()
		{
			var cobertura01 = new Orcamento(1, 70, 30, PorcentagemServicos.Cobertura);
			var cobertura02 = new Orcamento(2, 70, 65, PorcentagemServicos.Cobertura);
			var master01 = new Orcamento(3, 50, 20, PorcentagemServicos.Master, true);
			var master02 = new Orcamento(4, 50, 60, PorcentagemServicos.Master, true);
			var master03 = new Orcamento(5, 50, 15, PorcentagemServicos.Master);
			var premium01 = new Orcamento(6, 40, 23, PorcentagemServicos.Premium, true);
			var premium02 = new Orcamento(7, 40, 23, PorcentagemServicos.Premium);
			var tradicional01 = new Orcamento(8, 30, 20, PorcentagemServicos.Tradicional);
			var tradicional02 = new Orcamento(9, 30, 32, PorcentagemServicos.Tradicional, true);

			var orcamentos = new List<IServico>()
			{
				new CoberturaServico(cobertura01),
				new CoberturaServico(cobertura02),
				new MasterServico(master01),
				new MasterServico(master02),
				new MasterServico(master03),
				new PremiumServico(premium01),
				new PremiumServico(premium02),
				new TradicionalServico(tradicional01),
				new TradicionalServico(tradicional02)
			};
			
			CalculaTaxaServicos calculaTaxaServicos = new CalculaTaxaServicos();
			calculaTaxaServicos.Calcular(orcamentos);
		}
	}
}
