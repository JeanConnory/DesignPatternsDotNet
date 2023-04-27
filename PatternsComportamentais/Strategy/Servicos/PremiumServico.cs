using DesignPatterns.PatternsComportamentais.Strategy.Interfaces;
using DesignPatterns.PatternsComportamentais.Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Strategy.Servicos
{
	public class PremiumServico : IServico
	{
		private Orcamento _orcamento;

		public PremiumServico(Orcamento orcamento)
		{
			_orcamento = orcamento;
		}

		public void CalcularServico()
		{
			var porcentagem = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
			_orcamento.ValorTotal += porcentagem;

			if (_orcamento.CupomDesconto)
			{
				Console.WriteLine($"\nValor sem desconto: {_orcamento.ValorTotal.ToString("C")}");
				_orcamento.ValorTotal -= _orcamento.ValorTotal * 0.02;
				Console.WriteLine($"Você recebeu cupom de 2% de desconto para suite Premium.\n");
			}

			Console.WriteLine($"Tipo Quarto: {_orcamento.Porcentagem}\nPorcentagem Serviço: {porcentagem.ToString("C")}\nQuant. Dias: {_orcamento.Quantidade}\n" +
				$"Valor dia: {_orcamento.ValorDiaria}\nValor Total: {_orcamento.ValorTotal}");
		}
	}
}
