using System.Collections.Generic;

namespace DecoratorPattern.Interfaces
{
    // Concrete component contract
    public interface IRecipe
    {
        IList<string> Ingredients { get; set; }
        void DisplayRecipe();
    }
}