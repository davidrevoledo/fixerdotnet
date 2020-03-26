# Fixer Dotnet
Libarary to consume https://fixer.io/product in .net

Original repo https://github.com/fixerAPI/fixer

[![CodeFactor](https://www.codefactor.io/repository/github/davidrevoledo/fixerdotnet/badge)](https://www.codefactor.io/repository/github/davidrevoledo/fixerdotnet)
[![Build status](https://ci.appveyor.com/api/projects/status/iytre288g53nh213?svg=true)](https://ci.appveyor.com/project/davidrevoledo/fixerdotnet)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
![NuGet](https://img.shields.io/nuget/v/Fixer.io.svg)
![NuGet](https://img.shields.io/nuget/dt/Fixer.io.svg)

# Installation

To Install from the Nuget Package Manager Console 

```sh
PM > Install-Package Fixer.io 
NET CLI - dotnet add package Fixer.io
paket paket add Fixer.io

```

# Usage
Using the libary should be straight forward 

Get Currencies information 
(Interfaces can be mocked for testing purpose)
``` C#

IExchangeRatesSource rates = new ExchangeRatesSource();
var root = rates.GetCurrenciesAsync("FixerApiKeyHere")
```

Made with ❤
