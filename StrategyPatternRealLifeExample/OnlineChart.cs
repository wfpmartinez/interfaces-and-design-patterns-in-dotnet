using System.Collections.Generic;
using StrategyPatternRealLifeExample.Interfaces;
using StrategyPatternRealLifeExample.Strategies;

namespace StrategyPatternRealLifeExample
{
    public class OnlineChart
    {
        public OnlineChart(Dictionary<PaymentType, IPaymentStrategy> strategies)
        {
            paymentStrategies = strategies;

        }
        public void CheckOut(PaymentType paymentType)
        {
            paymentStrategies[paymentType].ProcessPayment();
        }

        private IDictionary<PaymentType, IPaymentStrategy> paymentStrategies;
    }
}