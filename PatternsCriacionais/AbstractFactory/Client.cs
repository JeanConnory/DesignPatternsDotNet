using DesignPatterns.PatternsCriacionais.AbstractFactory.ParteCriacao.Factories;
using DesignPatterns.PatternsCriacionais.AbstractFactory.ParteCriacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.AbstractFactory
{
	public class Client
	{
		public void ConsultarRotinaAluno()
		{
			var continuar = true;

			while (continuar)
			{
				IFactory factory = null;

				Console.WriteLine("Selecione a rotina desejada: ");
				Console.WriteLine("1 - Segunda e Quinta");
				Console.WriteLine("2 - Terça e Sexta");
				Console.WriteLine("3 - Quarta e Sábado");

				Console.Write("Selecione a rotina desejada: ");
				string opcao = Console.ReadLine();

				switch (opcao)
				{
					case "1":
						factory = new SegundaQuintaFactory();
						break;
					case "2":
						factory = new TercaSextaFactory();
						break;
					case "3":
						factory = new QuartaSabadoFactory();
						break;
					default:
						break;
				}

				Console.Write("Deseja ver outra rotina? (1-Sim ou 2-Não)");
				var resp = Convert.ToInt32(Console.ReadLine());

				continuar = resp == 1;
			}
		}
	}
}
