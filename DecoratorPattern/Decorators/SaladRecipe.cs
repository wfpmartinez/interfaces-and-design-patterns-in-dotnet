using System;
using System.Collections.Generic;
using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators
{
    // Decorator class 
    public class SaladRecipe : Recipe
    {
        public SaladRecipe(List<string> ingredients) : base(ingredients)
        {

        }

        public override void DisplayRecipe() {
            Console.WriteLine("These are the ingredients for the Salad Recipe");
            base.DisplayRecipe();
        }
    }
}