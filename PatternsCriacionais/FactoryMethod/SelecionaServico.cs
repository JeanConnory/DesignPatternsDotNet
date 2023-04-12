using DesignPatterns.PatternsCriacionais.FactoryMethod.Enums;
using DesignPatterns.PatternsCriacionais.FactoryMethod.Interfaces;
using DesignPatterns.PatternsCriacionais.FactoryMethod.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.FactoryMethod
{
	public class SelecionaServico : ServicoFactory
	{
		public override IServico FabricarProduto(eTiposServicos tiposServicos)
		{
			switch (tiposServicos)
			{
				case eTiposServicos.tradicional:
					return new TradicionalServico();
				case eTiposServicos.premium:
					return new PremiumServico();
				case eTiposServicos.master:
					return new MasterServico();
				case eTiposServicos.cobertura:
					return new CoberturaServico();
				default:
					return null;
			}
		}
	}
}
