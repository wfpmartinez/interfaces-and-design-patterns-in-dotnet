using System;
using StrategyPatternRealLifeExample.Interfaces;

namespace StrategyPatternRealLifeExample.Strategies
{
    public class PaypalStrategy : IPaymentStrategy
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }
}