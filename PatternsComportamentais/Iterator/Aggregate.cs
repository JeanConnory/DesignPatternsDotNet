﻿using DesignPatterns.PatternsComportamentais.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Iterator
{
	public class Aggregate : IAggregate
	{
		private List<string> Collection = null;
		private int count = 0;

        public Aggregate()
        {
            Collection = new List<string>();
        }

		public IIterator GetIterator()
		{
			return new Iterator(this);
		}

		public string this[int index]
		{
			get
			{
				if (index < Collection.Count) 
				{ 
					return Collection[index];
				}
				else
				{
					return string.Empty;
				}
			}
			set
			{
				Collection.Add(value);
			}
		}

		public int Limit
		{
			get
			{
				return Collection.Count;
			}
		}

		
	}
}
