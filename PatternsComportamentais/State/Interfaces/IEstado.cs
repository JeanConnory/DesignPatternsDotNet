using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.State.Interfaces
{
	public interface IEstado
	{
		public void Acao(Context context);
	}
}
