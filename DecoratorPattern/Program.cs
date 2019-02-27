using System;
using System.Collections.Generic;
using DecoratorPattern.Components;
using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    // Client class
    class Program
    {
        static void Main(string[] args)
        {
            var cakeIngredients = new List<string>() {
                "2 and 3/4 cups (305 grams) cake flour (spooned & leveled)",
                "1 tablespoon baking powder",
                "3/4 teaspoon salt",
                "1 cup (240 ml) buttermilk room temperature",
                "2 teaspoons clear vanilla extract or pure vanilla extract",
                "1 cup (230 grams) unsalted butter softened to room temperature",
                "1 and 3/4 cup (350 grams) granulated sugar",
                "5 large egg whites room temperature"
            };

            var ceasarSaladIngredients = new List<string>() {
                "6 cloves garlic, peeled, divided",
                "3/4 cup mayonnaise5 anchovy fillets, minced",
                "6 tablespoons grated Parmesan cheese, divided",
                "1 teaspoon Worcestershire sauce",
                "1 teaspoon Dijon mustard",
                "1 tablespoon lemon juice, or more to tastesalt to tasteground black pepper to taste",
                "1/4 cup olive oil4 cups day-old bread, cubed",
                "1 head romaine lettuce, torn into bite-size pieces"
            };  

            var recipes = new List<Recipe>() {
                new SaladRecipe(ceasarSaladIngredients),
                new CakeRecipe(cakeIngredients)
            };

            foreach (var recipe in recipes)
            {
                recipe.DisplayRecipe();
                Console.WriteLine("\n");
            }
        }
    }
}
