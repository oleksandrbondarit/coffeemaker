using coffeemaker.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace coffeemaker.BL.Controller
{
	public class DrinkController
	{
		public Drink Drink;

		public DrinkController( string name, List<Ingredients> recipe)
		{
			Drink = new Drink(name, recipe);
		}

		public void Save()
		{
			var formatter = new BinaryFormatter();
			using (var fs = new FileStream("drinks.dat", FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, Drink);
			}
		}
		public DrinkController() //Це буде для завантаження даних, це реалізовано конструтом щоб використати відразу в UI як метод
		{
			var formatter = new BinaryFormatter();
			using (var fs = new FileStream("drinks.dat", FileMode.OpenOrCreate))
			{
				if (formatter.Deserialize(fs) is Drink drink)
				{
					Drink = drink;
				}
				//TODO: Що робиться якщо не прочитали дані?
			}
		}
	}
}
