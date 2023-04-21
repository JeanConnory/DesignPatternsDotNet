using DesignPatterns.PatternsEstruturais.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Decorator.Decorators
{
	public class AcessorioDecorator : PetDecorator
	{
		public AcessorioDecorator(IPet pet) : base(pet)
		{
		}

		public override double GetValorServico()
		{
			return base.GetValorServico() + 30.00;
		}

		public override string GetNomeServico()
		{
			return base.GetNomeServico() + "\n[+] Acessório";
		}
	}
}
