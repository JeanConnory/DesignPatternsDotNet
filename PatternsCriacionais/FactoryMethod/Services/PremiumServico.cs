using DesignPatterns.PatternsCriacionais.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.FactoryMethod.Services
{
	public class PremiumServico : IServico
	{
        public PremiumServico()
        {
            Console.WriteLine("Produto PREMIUM criado com sucesso!");
        }

        public void ExecutaCobrancaServico()
		{
			//Lógica de cobrança Premium
			throw new NotImplementedException();
		}
	}
}
