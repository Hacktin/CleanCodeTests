using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeTests.Entities
{
    public class CurrencyRate : IEntity
    {
        public int Currency { get; set; }
        public decimal Price { get; set; }
    }
}
