using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public class StrategyB : IStrategy

    {
        public void Execute()
        {
            Console.WriteLine("Strategy B");
        }
    }
}