﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Interpreter.Jumanji.Interfaces
{
	public interface IExpressao
	{
		void Interpretar(Contexto contexto);
	}
}
