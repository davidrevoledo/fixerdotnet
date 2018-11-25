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

            var root = rates.GetCurrenciesAsync("ApiKeyHere")
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
