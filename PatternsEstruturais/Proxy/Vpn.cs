using DesignPatterns.PatternsEstruturais.Proxy.Interfaces;
using DesignPatterns.PatternsEstruturais.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Proxy
{
	public class Vpn : IProxy
	{
		public void AcessarVpn(User user)
		{
            Console.WriteLine("[+] - Acessando VPN\n");
			Thread.Sleep(2000);
            Console.WriteLine($"{user.Username}, você está logado na VPN");
        }
	}
}
