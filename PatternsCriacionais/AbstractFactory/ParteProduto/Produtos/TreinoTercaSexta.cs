using DesignPatterns.PatternsCriacionais.AbstractFactory.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.AbstractFactory.ParteProduto.Produtos
{
	public class TreinoTercaSexta : ITreino
	{
        public TreinoTercaSexta()
        {
			this.ObterTreino();
		}

        public void ObterTreino()
		{
			Console.WriteLine("Treino de TERÇA e SEXTA");
		}
	}
}
