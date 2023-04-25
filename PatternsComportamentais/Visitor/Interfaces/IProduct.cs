using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.Visitor.Interfaces
{
	public interface IProduct
	{
        public string NomeProduto { get; set; }

        public double Peso { get; set; }

        public double GetImposto(IVisitor visitor);
    }
}
