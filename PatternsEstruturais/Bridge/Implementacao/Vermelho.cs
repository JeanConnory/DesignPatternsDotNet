﻿using DesignPatterns.PatternsEstruturais.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Bridge.Implementacao
{
	public class Vermelho : ICor
	{
		public string ConsultarQuantidadePorCor(string tipoAbstracao)
		{
			//Implementa complexidade de consultar BD quantidade por cor
			var random = new Random();
			var quantidade = random.Next(100, 500);

			return $"Existem {quantidade} para {tipoAbstracao} de cor vermelha no estoque";

		}
	}
}
