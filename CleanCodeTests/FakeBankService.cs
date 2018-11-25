using CleanCodeTests.Entities;

namespace CleanCodeTests
{
    public class FakeBankService : IBankService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            return currencyRate.Price / (decimal)5.30;
        }
    }
}
