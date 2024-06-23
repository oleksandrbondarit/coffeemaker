using System;
using System.Collections.Generic;


namespace coffeemaker.BL.Model
{
	[Serializable]
	public class Drink
	{
		public string Name { get; set; }
		public List<Ingredients> Recipe { get; set; }

		public Drink( string name, List<Ingredients> recipe)
		{
			Name = name;
			Recipe = recipe;
		}

	}
}
