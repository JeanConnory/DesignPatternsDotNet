using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Memento
{
	public class CareTaker
	{
		private Snapshot _snapshot;//Memento

		public void AddSnapshot(Snapshot snapshot)
		{
			_snapshot = snapshot;
		}

		public Snapshot GetSnapshot()
		{
			return _snapshot;
		}
	}
}
