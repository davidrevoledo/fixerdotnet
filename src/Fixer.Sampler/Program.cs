using Fixer.dotnet;
using System;
using Fixer.dotnet.Abstractions;

namespace Fixer.Sampler
{
    class Program
    {
        static void Main(string[] args)
        {
            IExchangeRatesSource rates = new ExchangeRatesSource();

            var root = rates.GetCurrenciesAsync("9e0d9b7439d09290cd6365ed0999e083")
                .GetAwaiter()
                .GetResult();

            foreach (var currency in root.Currencies)
            {
                Console.WriteLine($"Currency {currency.Symbol} factor {currency.Factor}");
            }

            Console.ReadLine();
        }
    }
}
