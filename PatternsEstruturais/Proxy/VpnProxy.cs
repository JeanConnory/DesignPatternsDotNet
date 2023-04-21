using DesignPatterns.PatternsEstruturais.Proxy.Interfaces;
using DesignPatterns.PatternsEstruturais.Proxy.Model;
using DesignPatterns.PatternsEstruturais.Proxy.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Proxy
{
	public class VpnProxy : IProxy
	{
		public void AcessarVpn(User user)
		{
			DatabaseConnection sql = new DatabaseConnection();
			sql.RegistrarAcessoVpn(user);
            Console.WriteLine(new String('-', 40));
			Vpn vpn= new Vpn();
			vpn.AcessarVpn(user);
        }
	}
}
