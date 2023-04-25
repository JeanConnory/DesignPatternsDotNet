﻿using DesignPatterns.PatternsComportamentais.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Observer.Subjects
{
	public class PrimeVideos : ISujeito
	{
		public List<IObservavel> Observaveis { get; set; }

        public PrimeVideos()
        {
			Observaveis = new List<IObservavel>();
        }

        public void AddObservavel(IObservavel observavel)
		{
			Observaveis.Add(observavel);
		}

		public void NotificaObservavel()
		{
			foreach (var observavel in Observaveis)
			{
				observavel.Update();
                Console.WriteLine(new String('-', 50));
            }
		}

		public void RemoveObservavel(IObservavel observavel)
		{
			Observaveis?.Remove(observavel);
		}
	}
}
