using DesignPatterns.PatternsEstruturais.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Proxy
{
	public class Client
	{
		public void TentarConexaoClientVpn()
		{
			VpnProxy proxy = new VpnProxy();

			Console.Write("Digite o Username: ");
			string username = Console.ReadLine();

			Console.Write("Digite o Password");
			string password = Console.ReadLine();

			var user = new User(username, password);
			proxy.AcessarVpn(user);
		}
	}
}
