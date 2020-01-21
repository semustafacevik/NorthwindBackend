using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Business.Abstract
{
    public interface IUserService
    {
        IList<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
