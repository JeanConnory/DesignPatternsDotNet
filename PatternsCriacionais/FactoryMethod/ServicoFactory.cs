using DesignPatterns.PatternsCriacionais.FactoryMethod.Enums;
using DesignPatterns.PatternsCriacionais.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.FactoryMethod
{
	public abstract class ServicoFactory
	{
		public abstract IServico FabricarProduto(eTiposServicos tiposServicos);
	}
}
