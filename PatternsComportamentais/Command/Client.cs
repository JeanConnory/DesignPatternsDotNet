using DesignPatterns.PatternsComportamentais.Command.Commands;
using DesignPatterns.PatternsComportamentais.Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Command
{
	public class Client
	{
		public void FalarComandos()
		{
			var luminaria = new LuzLuminariaReceiver();

			ControleInvoker controle = new ControleInvoker();

			controle.AddCommand("LigaLuz", new LigaLuminariaCommand(luminaria));
			controle.AddCommand("DesligaLuz", new DesligaLuminariaCommand(luminaria));
			controle.AddCommand("AumentaIntensidade", new AumentaIntensidadeCommand(luminaria));
			controle.AddCommand("DiminuiIntensidade", new DiminuiIntensidadeCommand(luminaria));

			controle.ExecuteCommand("LigaLuz");

			controle.ExecuteCommand("AumentaIntensidade");

			controle.ExecuteCommand("DiminuiIntensidade");
			controle.ExecuteCommand("DiminuiIntensidade");
			controle.ExecuteCommand("DiminuiIntensidade");
			controle.ExecuteCommand("DiminuiIntensidade");
			controle.ExecuteCommand("DiminuiIntensidade");
			controle.ExecuteCommand("DiminuiIntensidade");

			controle.ExecuteCommand("AumentaIntensidade");
			controle.ExecuteCommand("AumentaIntensidade");
			controle.ExecuteCommand("AumentaIntensidade");
			controle.ExecuteCommand("AumentaIntensidade");
			controle.ExecuteCommand("AumentaIntensidade");

			controle.ExecuteCommand("DesligaLuz");
		}
	}
}
