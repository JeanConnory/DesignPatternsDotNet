using DesignPatterns.PatternsEstruturais.Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Composite
{
	public class Client
	{
		public void EfetuarCompra()
		{
			ComponentModel product01 = new ProductLeaf("Caneca Batman", 25.00);
			ComponentModel product02 = new ProductLeaf("Camiseta Star Wars", 80.00);
			ComponentModel product03 = new ProductLeaf("Chaveiro Vingadores", 10.00);

			ComponentModel product04 = new ProductLeaf("Estátua do Thanos", 500.00);

			ComponentModel smallBox = new ProductComposite();
			smallBox.Add(product01, product02, product03);

			ComponentModel bigBox = new ProductComposite();
			bigBox.Add(smallBox, product04);

			var valorTotal = bigBox.Operation();

            Console.WriteLine($"\nValor Total: {valorTotal.ToString("C")}");
        }
	}
}
