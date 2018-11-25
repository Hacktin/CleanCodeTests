using CleanCodeTests.BusinessLayer;
using CleanCodeTests.Entities;
using CleanCodeTests.ExternalService;
using System;

namespace CleanCodeTests
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new FakeBankService());
            productService.Sell(new Product { Id = 1, Name = "Laptop", Price = 1000 },
            new Customer { Id = 1, Name = "Mahmut", IsStudent = true, IsOfficer = false });

            Console.Read();
        }
    }
}
