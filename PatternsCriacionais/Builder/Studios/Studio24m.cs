using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.Builder.Studios
{
	public class Studio24m : Studio
	{
		public override void DefinirValorStudio(decimal valor)
		{
			ValorStudio = valor;
		}

		public override void EscolherFinanciamento(string financiamento)
		{
			TipoFinanciamento = financiamento;
		}

		public override void EscolherPiso(string piso)
		{
			TipoPiso = piso;
		}
	}
}
