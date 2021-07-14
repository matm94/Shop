using Microsoft.AspNetCore.Mvc;
using Shop.Infrastructure.Models;
using Shop.Infrastructure.Services;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        
        public AccountController(IUserService userService)
        {
            _userService = userService;
            
        }

        [Route("register")]
        [HttpPost]
        public ActionResult Register([FromBody] RegisterUserDTO registerUserDto)
        {
            _userService.RegisterUser(registerUserDto);
            return Ok();
        }

        [Route("login")]
        [HttpPost]
        public ActionResult Login([FromBody] LoginUserDTO loginUserDTO)
        {
            var token =_userService.LoginUser(loginUserDTO);
            return Ok(token);
        }
    }
}
