using DesignPatterns.PatternsComportamentais.TemplateMethod.AbstractModel;
using DesignPatterns.PatternsComportamentais.TemplateMethod.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamentais.TemplateMethod
{
	public class ConvertJSON : ProcessaDados
	{
        public ConvertJSON(string json) : base(json: json)
        {            
        }

		public override void ProcessarJSON()
		{
			this.pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(this.json);
			this.ApresentarValores();
		}

	}
}
