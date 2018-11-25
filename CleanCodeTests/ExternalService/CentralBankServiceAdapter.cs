using CleanCodeTests.Entities;

namespace CleanCodeTests.ExternalService
{
    public class CentralBankServiceAdapter : IBankService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            CentralBankService centralBankService = new CentralBankService();
            return centralBankService.ConvertCurrency(currencyRate);
        }
    }
}
