using System;

namespace DecoratorPatter_CanonicalExample
{
    public class DecoratorComponent : IComponent
    {
        public DecoratorComponent(IComponent decoratedComponent)
        {
            this.decoratedComponent = decoratedComponent;
        }
        public void DoSomething()
        {
            DoSomethingElse();
            decoratedComponent.DoSomething();
        }

        private void DoSomethingElse() { 
            Console.WriteLine("Doing something else from Decorator class");
        }

        private readonly IComponent decoratedComponent;
    }
}