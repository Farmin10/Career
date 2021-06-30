using career.BLL.Abstract;
using career.DTO.UserDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace career.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }



        /// <summary>
        /// Giriş
        /// </summary>
        /// <param name="userForLoginDto"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<ActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = await _authService.Login(userForLoginDto);
            if (userToLogin!=null)
            {
                return Ok(userToLogin);
            }

            var result = await _authService.CreateAccessToken(userToLogin);
            if (result!=null)
            {
                return Ok(result);
            }

            return Ok(userToLogin);
        }



        /// <summary>
        /// Qeydiyyat
        /// </summary>
        /// <param name="userForRegisterDto"></param>
        /// <returns></returns>
        [HttpPost("register")]
        public async Task<ActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            ;
            if (!await _authService.UserExists(userForRegisterDto.UserName))
            {
                return BadRequest();
            }

            var registerResult = await _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = await _authService.CreateAccessToken(registerResult);
            if (result!=null)
            {
                return Ok(result);
            }

            return BadRequest();
        }
    }
}
