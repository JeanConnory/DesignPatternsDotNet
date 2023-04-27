using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Memento
{
	public class VideoCassete
	{
		public void ExecutarAcaoVideo()
		{
			Originator originator = new Originator();
			originator.Estado = "Play";

			CareTaker careTaker = new CareTaker();
			careTaker.AddSnapshot(originator.CreateSnapshot());

			originator.Estado = "Pause";

			originator.Restore(careTaker.GetSnapshot());
		}
	}
}
