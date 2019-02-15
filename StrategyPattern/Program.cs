using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IStrategy strategy = new StrategyA();
            strategy.Execute(); 

            strategy = new StrategyB();
            strategy.Execute(); 

            strategy = new StrategyC();
            strategy.Execute(); 
            
            Console.ReadLine();
        }
    }
}
