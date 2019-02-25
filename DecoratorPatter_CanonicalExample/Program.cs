using System;

namespace DecoratorPatter_CanonicalExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new DecoratorComponent(new ConcreteComponent());
            component.DoSomething();
        }
    }
}
