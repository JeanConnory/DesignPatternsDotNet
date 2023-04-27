﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Mediator.AbstractModel
{
	public abstract class Mediador
	{
		public abstract void Enviar(string mensagem, Contato contato);
	}
}
