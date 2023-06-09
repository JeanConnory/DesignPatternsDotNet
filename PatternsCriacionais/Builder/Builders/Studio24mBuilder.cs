﻿using DesignPatterns.PatternsCriacionais.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacionais.Builder.Builders
{
	public class Studio24mBuilder : StudioBuilder
	{
        public Studio24mBuilder()
        {
            studio = new Studio24m();
        }

        public override void DefinirValorStudio()
		{
			studio.DefinirValorStudio(180000.00M);
		}

		public override void EscolherFinanciamento()
		{
			studio.EscolherFinanciamento("FinaMovelFinanciamentos");
		}

		public override void EscolherPiso()
		{
			studio.EscolherPiso("Cerâmica");
		}
	}
}
