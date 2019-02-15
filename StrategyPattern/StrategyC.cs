using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public class StrategyC : IStrategy

    {
        public void Execute()
        {
            Console.WriteLine("Strategy C");
        }
    }
}