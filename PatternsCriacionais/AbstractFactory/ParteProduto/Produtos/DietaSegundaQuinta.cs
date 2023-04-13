using DesignPatterns.PatternsCriacionais.AbstractFactory.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.AbstractFactory.ParteProduto.Produtos
{
	public class DietaSegundaQuinta : IDieta
	{
        public DietaSegundaQuinta()
        {
			this.ObterAlimentacao();
		}

        public void ObterAlimentacao()
		{
            Console.WriteLine("Dieta de SEGUNDA e QUINTA");
        }
	}
}
