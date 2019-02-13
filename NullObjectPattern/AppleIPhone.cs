using System;
using NullObjectPattern.Interfaces;

namespace NullObjectPattern
{
    public class AppleIPhone : ISmartPhone
    {
        public string Brand { get; set; } = "Apple";

        public void TurnOff()
        {
            Console.WriteLine("Turning off iPhone...");
        }

        public void TurOn()
        {
            Console.WriteLine("Turning on iPhone");
        }
    }
}