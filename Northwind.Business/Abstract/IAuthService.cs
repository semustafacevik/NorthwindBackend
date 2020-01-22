using Northwind.Core.Entities.Concrete;
using Northwind.Core.Utilities.Results;
using Northwind.Core.Utilities.Security;
using Northwind.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExits(string mail);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
