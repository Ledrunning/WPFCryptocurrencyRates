﻿namespace CryptoCurrencyRates.Client.Model;

public class RequiredRatesModel
{
    public CurrencyRates? Bitcoin { get; set; }
    public CurrencyRates? Dogecoin { get; set; }
    public CurrencyRates? Ethereum { get; set; }
}