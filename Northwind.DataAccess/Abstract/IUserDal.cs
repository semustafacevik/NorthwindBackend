using Northwind.Core.DataAccess;
using Northwind.Core.Entities.Concrete;
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
