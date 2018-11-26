using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeTests.Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public decimal Price { get; set; }
        public int CurrencyType { get; set; }
    }
}
