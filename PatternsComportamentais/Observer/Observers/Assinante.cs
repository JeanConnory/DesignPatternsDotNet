using DesignPatterns.PatternsComportamentais.Observer.Interfaces;
using DesignPatterns.PatternsComportamentais.Observer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Observer.Observers
{
	public class Assinante : IObservavel
	{
		public Assinante(Pessoa pessoa, string mensagem)
		{
			Pessoa = pessoa;
			Mensagem = mensagem;
		}

		public Pessoa Pessoa { get; set; }

        public string Mensagem { get; set; }

        public void Update()
		{
            //Simular envio de e-mail para assinante
            Console.WriteLine($"Eviando e-mail para: {Pessoa.Email}\n");
			Console.WriteLine($"Prezado {Pessoa.Nome}\n{Mensagem}");

			Console.WriteLine($"\nINSERT INTO TB_NOTIFICACAO (PessoaId, Notifica, Mes) VALUES ({Pessoa.Id}, 1, {DateTime.Now.Month})\n");
		}
	}
}
