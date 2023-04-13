using DesignPatterns.PatternsCriacionais.AbstractFactory.ParteCriacao.Interfaces;
using DesignPatterns.PatternsCriacionais.AbstractFactory.ParteProduto.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.AbstractFactory.ParteCriacao.Factories
{
	public class SegundaQuintaFactory : IFactory
	{
        public SegundaQuintaFactory()
        {
			this.ObterRotinaDiaria();
        }

        public void ObterRotinaDiaria()
		{
            Console.WriteLine("Factory Segunda e Quinta criada...");
            DietaSegundaQuinta dieta = new DietaSegundaQuinta();
            TreinoSegundaQuinta treino = new TreinoSegundaQuinta();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
	}
}
