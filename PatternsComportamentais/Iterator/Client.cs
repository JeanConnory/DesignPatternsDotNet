using DesignPatterns.PatternsComportamentais.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Iterator
{
	public class Client
	{
		public void ConsumirEstruturaDados()
		{
			Aggregate aggregate = new Aggregate();
			aggregate[0] = "Item 01";
			aggregate[1] = "Item 02";
			aggregate[2] = "Item 03";
			aggregate[3] = "Item 04";
			aggregate[4] = "Item 05";

			IIterator iterator = aggregate.GetIterator();

			for (string item = iterator.Next; iterator.HasNext; item = iterator.Next)
			{
                Console.WriteLine(item);
            }
		}
	}
}
