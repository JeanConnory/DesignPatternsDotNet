﻿using DesignPatterns.PatternsComportamentais.Command.Interfaces;
using DesignPatterns.PatternsComportamentais.Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Command.Commands
{
	public class LigaLuminariaCommand : ICommand
	{
		private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

		public LigaLuminariaCommand(LuzLuminariaReceiver luzLuminariaReceiver)
		{
			_luzLuminariaReceiver = luzLuminariaReceiver;
		}

		public void Execute()
		{
			_luzLuminariaReceiver.LigarLuz();
		}
	}
}
