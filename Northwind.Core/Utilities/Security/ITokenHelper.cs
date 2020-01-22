using Northwind.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Core.Utilities.Security
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, IList<OperationClaim> operationClaims);
    }
}
