using System;
using StrategyPatternRealLifeExample.Interfaces;

namespace StrategyPatternRealLifeExample.Strategies
{
    public class ApplePayStrategy : IPaymentStrategy
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing Apple payment...");
        }
    }
}