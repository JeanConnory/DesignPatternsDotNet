using DesignPatterns.PatternsEstruturais.Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Composite
{
	public class ProductLeaf : ComponentModel
	{
		private string _nome;
		private double _valor;

		public ProductLeaf(string nome, double valor)
		{
			_nome = nome;
			_valor = valor;
		}

		public override void Add(params ComponentModel[] components)
		{
            Console.WriteLine("Não é possível adicionar itens em um objeto do tipo leaf");
        }

		public override ComponentModel GetChild(int index)
		{
			Console.WriteLine("Não é possível adicionar itens em um objeto do tipo leaf");
			return null;
		}

		public override double Operation()
		{
            Console.WriteLine($"Produto: {_nome}\nValor: {_valor.ToString("C")}");
			Console.WriteLine(new String('-', 40));
			return _valor; 
        }

		public override void Remove(ComponentModel component)
		{
			Console.WriteLine("Não é possível remover itens em um objeto do tipo leaf");
		}
	}
}
