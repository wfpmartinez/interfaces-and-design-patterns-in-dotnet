using System;

namespace ClassAdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dependency = new Adapter();
            dependency.MethodA();
        }
    }
}
