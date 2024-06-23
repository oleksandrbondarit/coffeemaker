using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeemaker.BL.Model
{
	[Serializable]
	public class Ingredients
	{
		public string Name { get; set; }
		public float Quantity { get; set; }

		public Ingredients(string name, float quantity )
		{
			Name = name;
			Quantity = quantity;
		}
		public Ingredients(string name)
		{
			Name = name;
		}
	}
}
