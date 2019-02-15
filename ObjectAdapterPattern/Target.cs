using System;
using ObjectAdapterPattern.Interfaces;

namespace ObjectAdapterPattern
{
    public class Target : ITarget
    {
        public virtual void Request() {
            Console.WriteLine("Called Target.Request()");
        }
    }
}