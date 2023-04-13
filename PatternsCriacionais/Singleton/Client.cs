using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.Singleton
{
	public class Client
	{
		public void ConsumirDB()
		{
			var instancia = ContextDB.Instancia;
			instancia.ExecutaQuery("SELECT * FROM Nome_Tabela;");

			instancia = ContextDB.Instancia;
			instancia.ExecutaQuery("INSERT INTO Nome_Tabela (valor) VALUES (0001);");

			instancia = ContextDB.Instancia;
			instancia.ExecutaQuery("UPDATE Nome_Tabela SET valor = 0002 WHERE Id = 1;");

			instancia = ContextDB.Instancia;
			instancia.ExecutaQuery("DELETE Nome_Tabela WHERE Id = 1;");
		}
	}
}
