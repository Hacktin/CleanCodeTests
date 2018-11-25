using CleanCodeTests.Entities;

namespace CleanCodeTests.BusinessLayer
{
    interface IProductService
    {
        void Sell(Product product,Customer customer);
    }
}
