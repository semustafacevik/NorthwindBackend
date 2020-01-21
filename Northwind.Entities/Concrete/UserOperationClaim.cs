﻿using Northwind.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int OperationClaimID { get; set; }
    }
}
