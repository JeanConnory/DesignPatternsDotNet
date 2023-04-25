using DesignPatterns.PatternsComportamentais.Visitor.Interfaces;
using DesignPatterns.PatternsComportamentais.Visitor.Produtos;
using DesignPatterns.PatternsComportamentais.Visitor.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Visitor
{
	public class Fiscal
	{
		public void CalcularImpostos()
		{
			CalcularProdutosPereciveis();
            Console.WriteLine(new String('-', 40));
			CalcularProdutosNaoPereciveis();
        }

		private static void CalcularProdutosPereciveis()
		{
			List<ProdutoPerecivel> produtoPereciveis = new List<ProdutoPerecivel>()
			{
				new ProdutoPerecivel("Especiarias", 2500),
				new ProdutoPerecivel("Polpas de frutas", 2000)
			};

			Console.WriteLine("\nCalculando imposto produtos perecíveis:\n");

			foreach (var pp in produtoPereciveis)
			{
				Console.WriteLine($"Produto: {pp.NomeProduto}\nPeso: {pp.Peso}");

				foreach (var visitor in GetVisitor())
				{
					visitor.CalcularImpostoProdutoPerecivel(pp);
				}
				Console.WriteLine();
			}
		}

		private static void CalcularProdutosNaoPereciveis()
		{
			List<ProdutoNaoPerecivel> produtoNaoPereciveis = new List<ProdutoNaoPerecivel>()
			{
				new ProdutoNaoPerecivel("Antena wifi", 500),
				new ProdutoNaoPerecivel("Perfume Francês", 1000)
			};

            Console.WriteLine("\nCalculando imposto produtos não perecíveis:\n");

			foreach (var pnp in produtoNaoPereciveis)
			{
                Console.WriteLine($"Produto: {pnp.NomeProduto}\nPeso: {pnp.Peso}");

				foreach (var visitor in GetVisitor())
				{
					visitor.CalcularImpostoProdutoNaoPerecivel(pnp);
				}
				Console.WriteLine();
            }
        }

		private static List<IVisitor> GetVisitor() => new List<IVisitor>()
		{
			new RioDeJaneiroVisitor(), new SaoPauloVisitor()
		};
	}
}
