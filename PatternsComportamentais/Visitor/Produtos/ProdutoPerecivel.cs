using DesignPatterns.PatternsComportamentais.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Visitor.Produtos
{
	public class ProdutoPerecivel : IProduct
	{
		public ProdutoPerecivel(string nomeProduto, double peso)
		{
			NomeProduto = nomeProduto;
			Peso = peso;
		}

		public string NomeProduto { get; set; }
		public double Peso { get; set; }

		public double GetImposto(IVisitor visitor)
		{
			return visitor.CalcularImpostoProdutoPerecivel(this);
		}
	}
}
