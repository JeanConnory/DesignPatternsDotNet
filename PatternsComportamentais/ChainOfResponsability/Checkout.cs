using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.ChainOfResponsability
{
	public class Checkout
	{
		public Checkout(int clienteId, int qtdDias, double valorDiaria)
		{
			ClienteId = clienteId;
			QtdDias = qtdDias;
			ValorDiaria = valorDiaria;
			CalcularTotal();
		}

		public int ClienteId { get; set; }
        public int QtdDias { get; set; }
        public double ValorDiaria { get; set; }
        public double ValorTotal { get; set; }

		private void CalcularTotal()
		{
			this.ValorTotal = this.QtdDias * this.ValorDiaria;
		}
    }
}
