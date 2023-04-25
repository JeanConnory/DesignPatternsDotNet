using DesignPatterns.PatternsComportamentais.Observer.Interfaces;
using DesignPatterns.PatternsComportamentais.Observer.Model;
using DesignPatterns.PatternsComportamentais.Observer.Observers;
using DesignPatterns.PatternsComportamentais.Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Observer
{
	public class SendEmail
	{
		public void EnviarEmail()
		{
			string msgNaoAssinante = $"Notamos que ainda não faz parte da maior e melhor plataforma de séries e filmes, não fique de fora das promoções de " +
				$"{DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)} e acesse nossa plataforma para ver os mais recentes lançamentos.";

			string msgAssinante = $"Lançamentos para o mês {DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)} direto do cinema para sua tela.";

			List<IObservavel> observaveis = new List<IObservavel>()
			{
				new NaoAssinante(new Pessoa(1, "José", "jose@gmail.com"), msgNaoAssinante),
				new NaoAssinante(new Pessoa(2, "Maria", "maria@gmail.com"), msgNaoAssinante),
				new Assinante(new Pessoa(3, "João", "joao@gmail.com"), msgAssinante),
				new Assinante(new Pessoa(4, "Marta", "marta@gmail.com"), msgAssinante)
			};

			PrimeVideos primeVideos = new PrimeVideos();

			foreach (var o in observaveis)
			{
				primeVideos.AddObservavel(o);
			}

			primeVideos.NotificaObservavel();
		}
	}
}
