using DesignPatterns.PatternsCriacionais.AbstractFactory.ParteCriacao.Interfaces;
using DesignPatterns.PatternsCriacionais.AbstractFactory.ParteProduto.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.AbstractFactory.ParteCriacao.Factories
{
	public class QuartaSabadoFactory : IFactory
	{
        public QuartaSabadoFactory()
        {
			this.ObterRotinaDiaria();
        }

        public void ObterRotinaDiaria()
		{
            Console.WriteLine("Factory Quarta e Sábado criada...");
            DietaQuartaSabado dieta = new DietaQuartaSabado();
            TreinoQuartaSabado treino = new TreinoQuartaSabado();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
	}
}
