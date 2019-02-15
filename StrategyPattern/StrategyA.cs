using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public class StrategyA : IStrategy

    {
        public void Execute()
        {
            Console.WriteLine("Strategy A");
        }
    }
}