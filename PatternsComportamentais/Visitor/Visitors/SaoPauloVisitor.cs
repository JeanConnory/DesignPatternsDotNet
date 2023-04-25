using DesignPatterns.PatternsComportamentais.Visitor.Interfaces;
using DesignPatterns.PatternsComportamentais.Visitor.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Visitor.Visitors
{
	public class SaoPauloVisitor : IVisitor
	{
		public double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel)
		{
			var imposto = (produtoNaoPerecivel.Peso / 100) + 7;
            Console.WriteLine($"Imposto São Paulo: {imposto}");
			return imposto;
        }

		public double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel)
		{
			var imposto = (produtoPerecivel.Peso / 100) + 12;
			Console.WriteLine($"Imposto São Paulo: {imposto}");
			return imposto;
		}
	}
}
