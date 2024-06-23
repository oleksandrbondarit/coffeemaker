using coffeemaker.BL.Model;
using coffeemaker.BL.Controller;
using System;
using System.Collections.Generic;


namespace coffemaker.CMD
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Вітаємо в додатку для налаштування кавового апарату");
			Console.WriteLine("Напишіть назву напою  s");
			var name = Console.ReadLine();
			List<Ingredients> ingredients = new List<Ingredients> { };
			Ingredients mango = new Ingredients("mango");
			ingredients.Add(mango);
			var recipe = ingredients;
			var drinkController = new DrinkController(name, recipe);
			drinkController.Save();
		}
	}
}
