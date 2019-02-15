using System;

namespace ClassAdapterPattern
{
    public class Adapter : Adaptee
    {
        public void MethodA() {
            Console.WriteLine("Method adapted from the Adapter class");
            MethodB();
        }
    }
}