using System;
using System.Collections.Generic;
using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators
{
    // Decorator class 
    public class CakeRecipe : Recipe
    {
        public CakeRecipe(List<string> ingredients) : base(ingredients)
        {

        }

        public override void DisplayRecipe() {
            Console.WriteLine("These are the ingredients for the Vainilla Cake Recipe");
            base.DisplayRecipe();
        }
    }
}