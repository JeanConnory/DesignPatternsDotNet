using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.Prototype
{
	public class Client
	{
		public void Consumir()
		{
			GerenciadorVendasStudio gerenciador = new GerenciadorVendasStudio();

			gerenciador["24m"] = new Studio("24m2", "Financ1", 180000.00M);
			gerenciador["26m"] = new Studio("26m2", "Financ2", 190000.00M);
			gerenciador["28m"] = new Studio("28m2", "Financ3", 200000.00M);

			StudioModel firstClone01 = gerenciador["24m"].Clone();
			StudioModel firstClone02 = gerenciador["24m"].Clone();

			StudioModel studio26 = gerenciador["26m"].Clone();

			StudioModel studio28 = gerenciador["28m"].Clone();
		}
	}
}
