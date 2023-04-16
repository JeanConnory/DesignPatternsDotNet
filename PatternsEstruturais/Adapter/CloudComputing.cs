using DesignPatterns.PatternsEstruturais.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Adapter
{
	public class CloudComputing
	{
		IAdapter adapter;

        public CloudComputing()
        {
            this.adapter = new Adapter(new BusinessLegado());
        }

        public void ProcessarContas(string mes)
        {
            var result = this.adapter.ExecutarRotinaContasPagar(mes);
            Console.WriteLine("Processando camada cloud computing contas a pagar");
            Console.WriteLine(result);
            Thread.Sleep(3000);

            Console.WriteLine(new string('-', 40));

			result = this.adapter.ExecutarRotinaContasReceber(mes);
			Console.WriteLine("Processando camada cloud computing contas a receber");
            Console.WriteLine(result);
			Thread.Sleep(3000);

            Console.WriteLine("\nProcesso finalizado com sucesso!");
        }
    }
}
