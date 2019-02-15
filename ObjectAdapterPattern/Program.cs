using System;
using ObjectAdapterPattern.Interfaces;

namespace ObjectAdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget dependency = new Adapter(new Adaptee());
            dependency.Request();
        }
    }
}
