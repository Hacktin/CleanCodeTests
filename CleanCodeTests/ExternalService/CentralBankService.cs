using System;
using System.Collections.Generic;
using System.Text;
using CleanCodeTests.Entities;

namespace CleanCodeTests.ExternalService
{
    public class CentralBankService
    {
        public decimal ConvertCurrency(CurrencyRate currencyRate)
        {
            switch (currencyRate.Currency)
            {
                case 1:
                    return currencyRate.Price / (decimal)5.30;
                case 2:
                    return currencyRate.Price / (decimal)6.0;
                default:
                    return currencyRate.Price;
            }
            
        }
    }
}
