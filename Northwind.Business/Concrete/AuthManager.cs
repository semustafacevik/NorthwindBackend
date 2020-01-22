using Northwind.Business.Abstract;
using Northwind.Business.Contants;
using Northwind.Core.Entities.Concrete;
using Northwind.Core.Utilities.Results;
using Northwind.Core.Utilities.Security;
using Northwind.Core.Utilities.Security.Hashing;
using Northwind.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }
        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }
            return new SuccessDataResult<User>(userToCheck, Messages.SuccessLogin);
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IResult UserExits(string mail)
        {
            if (_userService.GetByMail(mail) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExits);
            }
        }
    }
}
