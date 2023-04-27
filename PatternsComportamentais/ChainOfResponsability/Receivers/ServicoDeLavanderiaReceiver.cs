using DesignPatterns.PatternsComportamentais.ChainOfResponsability.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.ChainOfResponsability.Receivers
{
	public class ServicoDeLavanderiaReceiver : CobrancaReceiver
	{
		public override Checkout ExecutarCobrancaServico(Checkout checkout)
		{
            Console.WriteLine("Realizando cobrança taxa de lavanderia...");
			checkout.ValorTotal += (checkout.ValorTotal * 0.028);
            return base.ExecutarCobrancaServico(checkout);
		}
	}
}
