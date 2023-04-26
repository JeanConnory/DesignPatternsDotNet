using DesignPatterns.PatternsComportamentais.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Command
{
	public class ControleInvoker
	{
		private Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();

		public void AddCommand(string key, ICommand command)
		{
			this.Commands.Add(key, command);
		}

		public void ExecuteCommand(string key)
		{
			if(!this.Commands.ContainsKey(key))
                Console.WriteLine("Comando Inexistente");
			else
				this.Commands[key].Execute();
        }
	}
}
