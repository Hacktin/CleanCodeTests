using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeTests.Entities
{
    public class Customer: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsStudent { get; set; }
        public bool IsOfficer { get; set; }
    }
}
