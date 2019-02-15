using System;

namespace ObjectAdapterPattern
{
    public class Adaptee
    {
        public void SpecificMethod()
        {
            Console.WriteLine("Called Adaptee.SpecificMethod()");
        }
    }
}