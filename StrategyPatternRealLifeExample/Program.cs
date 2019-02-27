using System;
using System.Collections.Generic;
using StrategyPatternRealLifeExample.Interfaces;
using StrategyPatternRealLifeExample.Strategies;

namespace StrategyPatternRealLifeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentStrategies = new Dictionary<PaymentType, IPaymentStrategy>();
            paymentStrategies.Add(PaymentType.CreditCard, new PaypalStrategy());
            paymentStrategies.Add(PaymentType.ApplePay, new ApplePayStrategy());
            paymentStrategies.Add(PaymentType.GooglePay, new GooglePayStrategy());

            var onlineChart = new OnlineChart(paymentStrategies);

            onlineChart.CheckOut(PaymentType.CreditCard);
            onlineChart.CheckOut(PaymentType.ApplePay);
            onlineChart.CheckOut(PaymentType.GooglePay);
        }
    }
}
