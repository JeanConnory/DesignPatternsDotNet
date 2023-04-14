using DesignPatterns.PatternsCriacionais.Builder.Builders;
using DesignPatterns.PatternsCriacionais.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.Builder
{
	public class Client
	{
		public void ConsumirDadosStudio()
		{
			Director director = new Director();
			StudioBuilder studioBuilder;
			Studio studio;

			studioBuilder = new Studio24mBuilder();
			director.ConstruirStudio(studioBuilder);
			studio = studioBuilder.GetStudio();
			ImprimirResultado(studio, "24m2");

			studioBuilder = new Studio26mBuilder();
			director.ConstruirStudio(studioBuilder);
			studio = studioBuilder.GetStudio();
			ImprimirResultado(studio, "26m2");

			studioBuilder = new Studio28mBuilder();
			director.ConstruirStudio(studioBuilder);
			studio = studioBuilder.GetStudio();
			ImprimirResultado(studio, "28m2");

		}

		private void ImprimirResultado(Studio studio, string nome)
		{
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"[+] - Studio {nome}");
			Console.WriteLine("Valor: {0}\n Piso: {1}\n Financiamento: {2}", studio.ValorStudio.ToString("C"), studio.TipoPiso, studio.TipoFinanciamento);
        }
	}
}
