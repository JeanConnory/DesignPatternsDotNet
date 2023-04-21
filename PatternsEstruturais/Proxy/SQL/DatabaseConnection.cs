using DesignPatterns.PatternsEstruturais.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Proxy.SQL
{
	public class DatabaseConnection
	{
		public void RegistrarAcessoVpn(User user)
		{
			var query = $"INSERT INTO tb_registroVpn (User, Password, Datahora)\nVALUES ('{user.Username}', '{user.Password}'," +
				$"{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")})\n";

            Console.WriteLine("[!] - Registrando acesso pelo proxy... \n");
            Console.WriteLine(query);
        }
	}
}
