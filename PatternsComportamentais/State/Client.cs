﻿using DesignPatterns.PatternsComportamentais.State.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.State
{
	public class Client
	{
		public void ExecutarContext()
		{
			Context context = new Context(new EstadoA());

			context.Trocar();
			context.Trocar();
		}
	}
}
