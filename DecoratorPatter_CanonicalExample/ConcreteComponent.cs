using System;

namespace DecoratorPatter_CanonicalExample
{
    public class ConcreteComponent : IComponent
    {
        public void DoSomething()
        {
            Console.WriteLine("Doing something from ConcreteComponent");
        }
    }
}