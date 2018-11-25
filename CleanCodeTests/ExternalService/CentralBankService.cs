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
            return currencyRate.Price / (decimal)5.30;
        }
    }
}
