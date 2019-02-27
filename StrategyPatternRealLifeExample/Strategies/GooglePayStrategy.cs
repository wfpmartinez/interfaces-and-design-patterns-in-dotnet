using System;
using StrategyPatternRealLifeExample.Interfaces;

namespace StrategyPatternRealLifeExample.Strategies
{
    public class GooglePayStrategy : IPaymentStrategy
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing Google payment...");
        }
    }
}