using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Interpreter.Jumanji.MooseFinbar.PontosFortes
{
	public class Zoologia : IPontoForte
	{
		public void Interpretar(Contexto contexto)
		{
			contexto.Conteudo += "[+] - Expert em Zoologia\n";
		}
	}
}
