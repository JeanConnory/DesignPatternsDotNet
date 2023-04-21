using DesignPatterns.PatternsEstruturais.Decorator.Decorators;
using DesignPatterns.PatternsEstruturais.Decorator.Interfaces;
using DesignPatterns.PatternsEstruturais.Decorator.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Decorator
{
	public class Client
	{
		public void ConsumirServicos()
		{
			IPet banhoTosa = new BanhoTosa("Banho e Tosa", 45.00);

			IPet acessorioDecorator = new AcessorioDecorator(banhoTosa);
			IPet luxoSpaDecorator = new LuxoSpaDecorator(acessorioDecorator);

            Console.WriteLine("Resumo dos serviços Pet Shop");

            Console.WriteLine(luxoSpaDecorator.GetNomeServico());
            Console.WriteLine("Valor Total: " + luxoSpaDecorator.GetValorServico());
        }
	}
}
