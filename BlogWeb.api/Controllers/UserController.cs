using BlogWeb.entity;
using BlogWeb.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlogWeb.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        UserService _userService;
        private readonly IConfiguration configuration;
        public UserController(UserService userService,IConfiguration configuration)
        {
            _userService = userService;
            this.configuration = configuration;
        }
        [HttpPost]
        [Route("Register")]
        public Result<User> Register(User user)
        {
            return _userService.Register(user);
        }
        [HttpGet]
        [Route("GetByUsername")]
        public Result<User> GetByUsername(string username)
        {
            return _userService.GetByUsername(username);
        }
        [HttpGet]
        [Route("GetToken")]
        public Result<User> GetToken(string username,string password)
        {
            if(_userService.Authenticate(username, password).isSuccess){
                var result = _userService.Authenticate(username, password);
                // Authentication(Yetkilendirme) başarılı ise JWT token üretilir.
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(configuration["Secret"]);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, result.data.username)
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                result.data.token = tokenHandler.WriteToken(token);
                return result;              
            }
                return _userService.Authenticate(username, password);
        }
    }
}
