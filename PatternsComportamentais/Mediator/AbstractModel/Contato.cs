﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Mediator.AbstractModel
{
	public abstract class Contato
	{
		protected Mediador Mediador;

		protected Contato(Mediador mediador)
		{
			Mediador = mediador;
		}
	}
}
