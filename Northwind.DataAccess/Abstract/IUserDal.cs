using Northwind.Core.DataAccess;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        IList<OperationClaim> GetClaims(User user);
    }
}
