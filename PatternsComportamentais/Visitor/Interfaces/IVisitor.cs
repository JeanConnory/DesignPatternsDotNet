using DesignPatterns.PatternsComportamentais.Visitor.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Visitor.Interfaces
{
	public interface IVisitor
	{
		//Visita um produto e aplica a regra de calcular um imposto
		double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel);
		double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel);
	}
}
