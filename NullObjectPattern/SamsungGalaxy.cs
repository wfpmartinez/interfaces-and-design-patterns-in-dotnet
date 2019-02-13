using System;
using NullObjectPattern.Interfaces;

namespace NullObjectPattern
{
    public class SamsungGalaxy : ISmartPhone
    {
        public string Brand { get; set; } = "Samsung";

        public void TurnOff()
        {
            Console.WriteLine("Turning off Galaxy...");
        }

        public void TurOn()
        {
            Console.WriteLine("Turning on Galaxy");
        }
    }
}