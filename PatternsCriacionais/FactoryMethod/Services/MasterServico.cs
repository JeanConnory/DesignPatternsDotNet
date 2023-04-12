using DesignPatterns.PatternsCriacionais.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.FactoryMethod.Services
{
	public class MasterServico : IServico
	{
        public MasterServico()
        {
            Console.WriteLine("Produto MASTER criado com sucesso!");
        }

        public void ExecutaCobrancaServico()
		{
			//Lógica de cobrança Master
			throw new NotImplementedException();
		}
	}
}
