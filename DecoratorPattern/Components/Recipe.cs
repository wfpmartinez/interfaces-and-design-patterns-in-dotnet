using System;
using System.Collections.Generic;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Components
{
    public class Recipe : IRecipe
    {
        public Recipe(List<string> ingredients)
        {
            Ingredients = ingredients;
        }

        public virtual void DisplayRecipe()
        {
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine(string.Format("{0} \n", ingredient));
            }
        }

        public IList<string> Ingredients { get; set; } = new List<string>();
    }
}