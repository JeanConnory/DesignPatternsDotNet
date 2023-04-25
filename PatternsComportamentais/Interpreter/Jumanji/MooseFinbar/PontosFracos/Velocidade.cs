using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Interpreter.Jumanji.MooseFinbar.PontosFracos
{
	public class Velocidade : IPontoFraco
	{
		public void Interpretar(Contexto contexto)
		{
			contexto.Conteudo += "[-] - Velocidade\n";
		}
	}
}
