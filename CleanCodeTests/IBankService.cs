using CleanCodeTests.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeTests
{
    public interface IBankService
    {
        decimal ConvertRate(CurrencyRate currencyRate);
    }
}
