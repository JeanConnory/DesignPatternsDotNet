using DesignPatterns.PatternsComportamentais.Interpreter.Jumanji.MooseFinbar.PontosFortes;
using DesignPatterns.PatternsComportamentais.Interpreter.Jumanji.MooseFinbar.PontosFracos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Interpreter.Jumanji
{
	public class ApresentaPopup
	{
		public void ApresentarHabilidadesPopup()
		{
			List<IPontoForte> pontoFortes = new List<IPontoForte>()
			{
				new Armeiro(), new Zoologia()
			};

			List<IPontoFraco> pontoFracos = new List<IPontoFraco>()
			{ 
				new Bolo(), new Forca(), new Velocidade()
			};

			var mooseFinbar = new Contexto("Moose Finbar");

			Habilidades habilidades = new Habilidades(pontoFortes, pontoFracos);
			habilidades.Interpretar(mooseFinbar);
		}
	}
}
