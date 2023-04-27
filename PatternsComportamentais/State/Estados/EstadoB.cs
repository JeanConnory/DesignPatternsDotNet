using DesignPatterns.PatternsComportamentais.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.State.Estados
{
	public class EstadoB : IEstado
	{
		public void Acao(Context context)
		{
			Console.WriteLine("Executando ações do estado B");
			context.Estado = new EstadoA();
		}
	}
}
