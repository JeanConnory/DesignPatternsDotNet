using DesignPatterns.PatternsCriacionais.AbstractFactory.ParteCriacao.Interfaces;
using DesignPatterns.PatternsCriacionais.AbstractFactory.ParteProduto.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.AbstractFactory.ParteCriacao.Factories
{
	public class TercaSextaFactory : IFactory
	{
        public TercaSextaFactory()
        {
			this.ObterRotinaDiaria();
        }

        public void ObterRotinaDiaria()
		{
            Console.WriteLine("Factory Terça e Sexta criada...");
            DietaTercaSexta dieta = new DietaTercaSexta();
            TreinoTercaSexta treino = new TreinoTercaSexta();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
	}
}
