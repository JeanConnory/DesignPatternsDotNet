using DesignPatterns.PatternsCriacionais.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.FactoryMethod.Services
{
	public class TradicionalServico : IServico
	{
        public TradicionalServico()
        {
            Console.WriteLine("Produto TRADICIONAL criado com sucesso!");
        }

        public void ExecutaCobrancaServico()
		{
			//Lógica de cobrança de produto Tradicional
			throw new NotImplementedException();
		}
	}
}
