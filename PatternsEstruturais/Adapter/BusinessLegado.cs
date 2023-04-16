using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Adapter
{
	public class BusinessLegado
	{
		public string ExecutarRotinaContasPagar(string mes)
		{
			var result = AcessoSQL.GetDadosPagar(mes);

            Console.WriteLine("\nProcessando regras de negócio contas a pagar...");
			//Aplicando as regras
			Thread.Sleep(3000);

			return result;
        }

		public string ExecutarRotinaContasReceber(string mes)
		{
			var result = AcessoSQL.GetDadosReceber(mes);

			Console.WriteLine("\nProcessando regras de negócio contas a receber...");
			//Aplicando as regras
			Thread.Sleep(3000);

			return result;
		}
	}

	public class AcessoSQL
	{
		public static string GetDadosPagar(string mes)
		{
			Dictionary<string, string> dic = new Dictionary<string, string>();
			dic.Add("junho", "junho\nCNPJ:123321123321\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-233");
			dic.Add("julho", "julho\nCNPJ:123321123321\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-233");
			dic.Add("agosto", "agosto\nCNPJ:123321123321\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-233");
			dic.Add("setembro", "setembro\nCNPJ:123321123321\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-233");
			dic.Add("outubro", "outubro\nCNPJ:123321123321\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-233");

			return dic[mes];
		}

		public static string GetDadosReceber(string mes)
		{
			Dictionary<string, string> dic = new Dictionary<string, string>();
			dic.Add("junho", "junho\nCNPJ:123321123321\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-233");
			dic.Add("julho", "julho\nCNPJ:123321123321\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-233");
			dic.Add("agosto", "agosto\nCNPJ:123321123321\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-233");
			dic.Add("setembro", "setembro\nCNPJ:123321123321\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-233");
			dic.Add("outubro", "outubro\nCNPJ:123321123321\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-233");

			return dic[mes];
		}
	}
}
