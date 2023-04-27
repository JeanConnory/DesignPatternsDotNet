using DesignPatterns.PatternsComportamentais.ChainOfResponsability.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.ChainOfResponsability.Receivers
{
	public class ServicoDeQuartoReceiver : CobrancaReceiver
	{
		public override Checkout ExecutarCobrancaServico(Checkout checkout)
		{
			Console.WriteLine("Realizando cobrança taxa de serviço de quarto...");
			checkout.ValorTotal += (checkout.ValorTotal * 0.03);
			return base.ExecutarCobrancaServico(checkout);
		}
	}
}
