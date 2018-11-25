using System;
using System.Collections.Generic;
using System.Text;
using CleanCodeTests.Entities;

namespace CleanCodeTests.BusinessLayer
{
    public class ProductManager : IProductService
    {
        private IBankService _bankService;
        public ProductManager(IBankService bankService)
        {
            _bankService = bankService;
        }
        public void Sell(Product product, Customer customer)
        {
            decimal price = product.Price;
            if (customer.IsStudent)
                price = product.Price * (decimal)0.90;
            if (customer.IsOfficer)
                price = product.Price * (decimal)0.80;

            price = _bankService.ConvertRate(new CurrencyRate { Currency = 1, Price = price });

            Console.WriteLine(price);
        }
    }
}
