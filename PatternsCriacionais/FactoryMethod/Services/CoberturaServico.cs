using DesignPatterns.PatternsCriacionais.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.FactoryMethod.Services
{
	public class CoberturaServico : IServico
	{
        public CoberturaServico()
        {
            Console.WriteLine("Produto COBERTURA criado com sucesso!");
        }

        public void ExecutaCobrancaServico()
		{
			//Lógica de cobraça de serviços para Cobertura
			throw new NotImplementedException();
		}
	}
}
