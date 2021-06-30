using career.DAL.Utilities.Security.JWT;
using career.DTO.UserDTO;
using career.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Abstract
{
    public interface IAuthService
    {
        Task<User> Register(UserForRegisterDto userForRegisterDto, string password);
        Task<User> Login(UserForLoginDto userForLoginDto);
        Task<bool> UserExists(string userName);
        Task<AccessToken> CreateAccessToken(User user);
    }
}
