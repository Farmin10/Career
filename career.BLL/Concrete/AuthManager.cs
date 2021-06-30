using career.BLL.Abstract;
using career.BLL.Constants;
using career.DAL.DataAccess;
using career.DAL.Utilities.Security.Hashing;
using career.DAL.Utilities.Security.JWT;
using career.DTO.UserDTO;
using career.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        IUnitOfWork _unitOfWork;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper, IUnitOfWork unitOfWork)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _unitOfWork = unitOfWork;
        }

        public async Task<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                UserName = userForRegisterDto.UserName,
                IsDeleted=false,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
            };
            await _userService.Add(user);
            _unitOfWork.Commit();
            return   user;
        }

        public async Task<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = await _userService.GetByUserName(userForLoginDto.UserName);
            if (userToCheck == null)
            {
                return userToCheck;
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return userToCheck;
            }

            return userToCheck;
        }

        public async Task<bool> UserExists(string userName)
        {
            if (await _userService.GetByUserName(userName) != null)
            {
                return false ;
            }
            return true ;
        }

        public async Task<AccessToken> CreateAccessToken(User user)
        {
            var accessToken = _tokenHelper.CreateToken(user);
            return accessToken;
        }
    }
}
