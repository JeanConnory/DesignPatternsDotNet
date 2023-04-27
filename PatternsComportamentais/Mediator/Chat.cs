﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Mediator
{
	public class Chat
	{
		public void Conversar()
		{
			MediadorConcreto mediador = new MediadorConcreto();

			Atendente atendente = new Atendente(mediador);
			Paciente paciente = new Paciente(mediador);

			mediador.Atendente = atendente;
			mediador.Paciente = paciente;

            Console.WriteLine("Chat: ");
			paciente.EnviarMensagem("Por favor, Eu gostaria de agendar uma consulta");
			atendente.EnviarMensagem("Sim, por favor, qual especialidade?");

			paciente.EnviarMensagem("Clinico geral");
			atendente.EnviarMensagem("Temos vaga para a próxima terça nos horários:\n16:30hs\n16:45hs\n17:00hs\n");

			paciente.EnviarMensagem("Pode agendar terça às 16:45");
			atendente.EnviarMensagem("Agendamento concluído com sucesso!");

			paciente.EnviarMensagem("Obrigado...");
			atendente.EnviarMensagem("Nós que agradecemos!");

            Console.WriteLine(new String('-', 40));
        }
	}
}
