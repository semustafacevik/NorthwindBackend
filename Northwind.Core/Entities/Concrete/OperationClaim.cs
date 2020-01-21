using Northwind.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Core.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
