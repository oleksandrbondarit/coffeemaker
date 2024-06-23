using coffeemaker.BL.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace coffeemaker.BL.Controller
{
	public class IngredientsController
	{
		public Ingredients Ingredients;

		public IngredientsController(string name, float quantity)
		{
			Ingredients = new Ingredients(name, quantity);
		}

		public void Save()
		{
			var formatter = new BinaryFormatter();
			using (var fs = new FileStream("ingredients.dat", FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, Ingredients);
			}
		}
		

		
		public IngredientsController() //Це буде для завантаження даних, це реалізовано конструтом щоб використати відразу в UI як метод
		{
			var formatter = new BinaryFormatter();
			using (var fs = new FileStream("ingredients.dat", FileMode.OpenOrCreate))
			{
				if (formatter.Deserialize(fs) is Ingredients ingredients)
				{
					Ingredients = ingredients;
				}
				//TODO: Що робиться якщо не прочитали дані?
			}
		}
	}
}
